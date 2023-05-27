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
            InitBrands();
        }

        private void InitBrands()
        {
            DataTable allTable = remoteHTTP.fullTable();
            foreach (DataRow row in allTable.Rows)
            {
                if (!ComboBoxBrand.Items.Contains(row["Brand"].ToString()))
                    ComboBoxBrand.Items.Add(row["Brand"].ToString());
            }
        }

        private void ComboBoxBrand_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable brandTable = remoteHTTP.findByBrand(ComboBoxBrand.SelectedItem.ToString());
            ComboBoxModel.Items.Clear();
            foreach (DataRow row in brandTable.Rows)
            {
                if (!ComboBoxModel.Items.Contains(row["Model"].ToString()))
                    ComboBoxModel.Items.Add(row["Model"].ToString());
            }
        }

        private void ComboBoxModel_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable guitar = remoteHTTP.findByModel(ComboBoxModel.SelectedItem.ToString());
            foreach (DataRow row in guitar.Rows)
            {
                brand_label.Text = "Производитель: " + row["Brand"].ToString();
                model_label.Text = "Модель: " + row["Model"].ToString();
                articul_label.Text = "Производитель: " + row["Articul"].ToString();
                price_label.Text = "Цена: " + row["Price"].ToString() + "р.";
                descriptionBox.Text = row["Description"].ToString();
                imageBox.Image = new Bitmap(row["Image"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
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

            }*/
        }
    }
}
