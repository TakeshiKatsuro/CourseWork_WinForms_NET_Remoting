using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Server
{    
    public class DB
    {
        const string conString = "Data Source=C:/Users/Руслан/source/repos/CourseWork_TP_WinForms/Server/DB_CourseWork.db";
        SQLiteConnection connection = new SQLiteConnection(conString);

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SQLiteConnection getConnection()
        {
            return connection;
        }
    }
}
