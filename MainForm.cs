using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_TP_2023
{
    public partial class MainForm : Form
    {
        public RemoteObjectHTTP remoteHTTP;
        HttpChannel channel = new HttpChannel(new Dictionary<string, string> { { "port", "0" } }, new BinaryClientFormatterSinkProvider(), new BinaryServerFormatterSinkProvider { TypeFilterLevel = TypeFilterLevel.Full });

        public MainForm()
        {
            InitializeComponent();
            ChannelServices.RegisterChannel(channel, false);
            remoteHTTP = new RemoteObjectHTTP();
            ILease lease = (ILease)remoteHTTP.InitializeLifetimeService();
            ClientSponsor clientHTTPSponsor = new ClientSponsor();
            lease.Register(clientHTTPSponsor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Руслан/source/repos/CourseWork_TP_WinForms/Server/DB_CourseWork.db"))
            {
                conn.Open();

                string sql = "SELECT * FROM users";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                SQLiteDataReader dataReader = cmd.ExecuteReader();

                while(dataReader.Read())
                {
                    listBox1.Items.Add(string.Format("{0}, {1}, {2}", dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2)));
                }

                conn.Close();

            }
        }
    }
}
