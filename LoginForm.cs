using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Serialization.Formatters;
using Server;
using System.Runtime.Remoting.Channels.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting;

namespace CourseWork_TP_2023
{
    public partial class LoginForm : Form
    {
        public RemoteObjectTCP remoteTCP;

        public LoginForm()
        {
            InitializeComponent();
            RemotingConfiguration.Configure("C:\\Users\\Руслан\\source\\repos\\CourseWork_TP_WinForms\\ClientConfig.config", false);
            remoteTCP = new RemoteObjectTCP();
            ILease lease = (ILease)remoteTCP.InitializeLifetimeService();
            ClientSponsor clientTCPSponsor = new ClientSponsor();
            lease.Register(clientTCPSponsor);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        Point lastPoint2;
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint2.X;
                this.Top += e.Y - lastPoint2.Y;
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint2 = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int response = remoteTCP.Autorization(loginField.Text, passField.Text);

            if (response == 1)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistryForm registryForm = new RegistryForm();
            registryForm.Show();
        }

        bool password_show = false;
        private void hide_btn_Click(object sender, EventArgs e)
        {
            password_show = !password_show;
            if (password_show)
            {
                hide_btn.Image = Properties.Resources.non_visible;
                passField.UseSystemPasswordChar = false;
            }
            else
            {
                hide_btn.Image = Properties.Resources.visible;
                passField.UseSystemPasswordChar = true;
            }
        }
    }
}

