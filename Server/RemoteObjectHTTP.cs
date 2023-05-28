using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Runtime.Remoting.Lifetime;
using System.IO;

namespace Server
{
    [Serializable]
    public class RemoteObjectHTTP : MarshalByRefObject, IGuitars
    {
        private string connectionString = "Data Source=C:/Users/Руслан/source/repos/CourseWork_TP_WinForms/Server/DB_CourseWork.db";

        public RemoteObjectHTTP()
        {
            Console.WriteLine("Удаленный объект HTTP создан!");
        }
        ~RemoteObjectHTTP()
        {
            Console.WriteLine("Удаленный объект HTTP уничтожен!");
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

        public DataTable fullTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                // открытие соединения
                conn.Open();

                DataTable dataTable = new DataTable(); // создание таблицы
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(string.Format("SELECT * FROM Guitars"), conn);
                adapter.Fill(dataTable); // запись результатов выполнения запроса в таблицу

                // закрытие соединения
                conn.Close();

                // возвращение таблицы
                return dataTable;
            }
        }

        public DataTable findByBrand(string brand)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                // открытие соединения
                conn.Open();

                DataTable dataTable = new DataTable(); // создание таблицы
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(string.Format("SELECT * FROM Guitars WHERE Brand='{0}'", brand), conn);
                adapter.Fill(dataTable); // запись результатов выполнения запроса в таблицу

                // закрытие соединения
                conn.Close();

                // возвращение таблицы
                return dataTable;
            }
        }

        public DataTable findByModel(string model)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                // открытие соединения
                conn.Open();

                DataTable dataTable = new DataTable(); // создание таблицы
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(string.Format("SELECT * FROM Guitars WHERE Model='{0}'", model), conn);
                adapter.Fill(dataTable); // запись результатов выполнения запроса в таблицу

                // закрытие соединения
                conn.Close();

                // возвращение таблицы
                return dataTable;
            }
        }
    }
}
