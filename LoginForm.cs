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

namespace CourseWork_TP_2023
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            /*this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 48);*/
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
            string login = loginField.Text;
            string password = passField.Text;

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Руслан/source/repos/CourseWork_TP_WinForms/DB_CourseWork.db;"))
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
                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль!");
                        }
                    }
                }
                conn.Close();
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

