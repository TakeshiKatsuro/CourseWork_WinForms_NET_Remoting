using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using Server;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting;

namespace CourseWork_TP_2023
{

    public partial class RegistryForm : Form
    {
        public RemoteObjectTCP remoteTCP;
        public RegistryForm()
        {
            InitializeComponent();
            RemotingConfiguration.Configure("C:\\Users\\Руслан\\source\\repos\\CourseWork_TP_WinForms\\ClientConfig.config", false);
            remoteTCP = new RemoteObjectTCP();
            ILease lease = (ILease)remoteTCP.InitializeLifetimeService();
            ClientSponsor clientTCPSponsor = new ClientSponsor();
            lease.Register(clientTCPSponsor);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            bool check = remoteTCP.isUserExists(userNameField.Text);

            if(userNameField.Text == "Логин")
            {
                MessageBox.Show("Введите логин.");
                return;
            }

            if(name1st.Text == "Введите имя")
            {
                MessageBox.Show("Введите, пожалуйста, имя");
                return;
            }

            if (name2nd.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите, пожалуйста, фамилию");
                return;
            }

            if (passField.Text == "Придумайте пароль")
            {
                MessageBox.Show("Поле <пароль> обязательное.");
                return;
            }

            if (passField.Text == "Подтвердите пароль")
            {
                MessageBox.Show("Пароли не совпадают/поле не заполнено!");
                return;
            }

            if (passField.Text != confirmField.Text)
            {
                MessageBox.Show("Пароли не совпадают/поле не заполнено!");
                return;
            }

            if (check == true)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
            }
            else
            {
                int response = remoteTCP.Registration(userNameField.Text, name1st.Text, name2nd.Text, passField.Text);
                if (response == 1)
                {
                    MessageBox.Show("Аккаунт был создан");
                }
                else
                    MessageBox.Show("Ошибка! Не удалось создать аккаунт");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Логин")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.White;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Логин";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void name1st_Enter(object sender, EventArgs e)
        {
            if (name1st.Text == "Введите имя")
            {
                name1st.Text = "";
                name1st.ForeColor = Color.White;
            }
        }

        private void name1st_Leave(object sender, EventArgs e)
        {
            if (name1st.Text == "")
            {
                name1st.Text = "Введите имя";
                name1st.ForeColor = Color.Gray;
            }
        }

        private void name2nd_Enter(object sender, EventArgs e)
        {
            if (name2nd.Text == "Введите фамилию")
            {
                name2nd.Text = "";
                name2nd.ForeColor = Color.White;
            }
        }

        private void name2nd_Leave(object sender, EventArgs e)
        {
            if (name2nd.Text == "")
            {
                name2nd.Text = "Введите фамилию";
                name2nd.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Придумайте пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.White;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Придумайте пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void confirmField_Enter(object sender, EventArgs e)
        {
            if (confirmField.Text == "Подтвердите пароль")
            {
                confirmField.Text = "";
                confirmField.ForeColor = Color.White;
            }
        }

        private void confirmField_Leave(object sender, EventArgs e)
        {
            if (confirmField.Text == "")
            {
                confirmField.Text = "Подтвердите пароль";
                confirmField.ForeColor = Color.Gray;
            }
        }

        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        bool password_show = true;
        private void hide_btn_Click(object sender, EventArgs e)
        {
            password_show = !password_show;
            if(password_show)
            {
                hide_btn.Image = Properties.Resources.non_visible;
                passField.UseSystemPasswordChar = false;
                confirmField.UseSystemPasswordChar = false;
            }
            else
            {
                hide_btn.Image = Properties.Resources.visible;
                passField.UseSystemPasswordChar = true;
                confirmField.UseSystemPasswordChar = true;
            }
        }
    }
}
