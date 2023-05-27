using System;
using System.Data.OleDb;
using System.Data;
using System.Data.SQLite;
using Server;
using System.Runtime.Remoting.Lifetime;
using System.IO;

namespace Server
{
    [Serializable]
    public class RemoteObjectTCP : MarshalByRefObject
    {
        public int Autorization(string login, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Руслан/source/repos/CourseWork_TP_WinForms/Server/DB_CourseWork.db"))
            {
                conn.Open();

                string sql = "SELECT * FROM users WHERE login=@username AND password=@password";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", login);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            conn.Close();
                            return 1;
                        }
                        else
                        {
                            conn.Close();
                            return 0;
                        }
                    }
                }
            }
        }

        public int Registration(string login, string name, string familia, string password)
        {
            DB db = new DB();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO users (login, password, first_name, last_name) " +
                "VALUES (@login, @pass, @1st_name, @2nd_name)", db.getConnection());
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@1st_name", name);
            command.Parameters.AddWithValue("@2nd_name", familia);
            command.Parameters.AddWithValue("@pass", password);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return 1;
            }
            else
            {
                db.closeConnection();
                return 0;
            }           
        }

        public Boolean isUserExists(string login)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Руслан/source/repos/CourseWork_TP_WinForms/Server/DB_CourseWork.db;"))
            {
                conn.Open();

                string sql = "SELECT * FROM users WHERE login=@username";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", login);

                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            conn.Close();
                            return true;
                        }
                        else
                        {
                            conn.Close();
                            return false;
                        }
                    }
                }
            }
        }

        public byte[] Upload(string path)
        {
            return File.ReadAllBytes("Sources\\" + path);
        }

        public override object InitializeLifetimeService()
        {
            ILease lease = (ILease)base.InitializeLifetimeService();

            if (lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime = TimeSpan.FromSeconds(3);
                lease.SponsorshipTimeout = TimeSpan.FromSeconds(10);
                lease.RenewOnCallTime = TimeSpan.FromSeconds(2);
            }
            return lease;
        }
    }
}
