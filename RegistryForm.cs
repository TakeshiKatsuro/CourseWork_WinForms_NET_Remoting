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
    public partial class RegistryForm : Form
    {
        public RegistryForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string login = userNameField.Text;
            string password = passField.Text;
            string confirm = confirmField.Text;
            string name = name1st.Text;
            string familia = name2nd.Text;

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

            if (isUserExists())
                return;

            DB db = new DB();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO users (login, password, first_name, last_name) " +
                "VALUES (@login, @pass, @1st_name, @2nd_name)", db.getConnection());
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@1st_name", name);
            command.Parameters.AddWithValue("@2nd_name", familia); 
            command.Parameters.AddWithValue("@pass", password);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Ошибка! Не удалось создать аккаунт");

            db.closeConnection();
        }

        public Boolean isUserExists()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Руслан/source/repos/CourseWork_TP_WinForms/DB_CourseWork.db;"))
            {
                conn.Open();

                string sql = "SELECT * FROM users WHERE login=@username";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", userNameField.Text);

                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            MessageBox.Show("Пользователь с таким логином уже существует");
                            return true;
                        }
                        else                   
                            return false;                        
                    }
                }
                conn.Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
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

        bool password_show = false;
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
