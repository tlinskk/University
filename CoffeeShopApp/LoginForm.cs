using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Введіть логін і пароль.");
                return;
            }

            string query = $"SELECT * FROM Users WHERE Username = '{username}'";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                string dbPassword = dt.Rows[0]["Password_hash"].ToString();
                if (dbPassword == password) // Поки без шифрування
                {
                    Session.UserId = Convert.ToInt32(dt.Rows[0]["idUsers"]);
                    Session.FullName = dt.Rows[0]["Full_name"].ToString();
                    Session.IsAdmin = Convert.ToInt32(dt.Rows[0]["Is_admin"]) == 1;

                    MessageBox.Show("Вхід успішний!");

                    if (Session.IsAdmin)
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else
                    {
                        UserForm userForm = new UserForm();
                        userForm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Невірний пароль!");
                }
            }
            else
            {
                MessageBox.Show("Користувача не знайдено!");
            }
        }


        // Перемикання між вкладками "Вхід" та "Реєстрація"
        private void linkRegister_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRegister; // Перехід до вкладки реєстрації
        }

        private void linkLogin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabLogin; // Перехід до вкладки входу
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtRegisterUsername.Text.Trim();
            string password = txtRegisterPassword.Text.Trim();
            string fullName = txtRegisterFullName.Text.Trim();

            // Перевірка на порожні поля
            if (username == "" || password == "" || fullName == "")
            {
                MessageBox.Show("Всі поля мають бути заповнені.");
                return;
            }

            // Перевірка, чи користувач уже існує
            string checkQuery = $"SELECT * FROM Users WHERE Username = '{username}'";
            DataTable checkDt = DatabaseHelper.ExecuteQuery(checkQuery);
            if (checkDt.Rows.Count > 0)
            {
                MessageBox.Show("Користувач з таким логіном вже існує.");
                return;
            }

            // Створення запиту на додавання користувача
            string insertQuery = $"INSERT INTO Users (Username, Password_hash, Full_name) VALUES ('{username}', '{password}', '{fullName}')";

            try
            {
                int result = DatabaseHelper.ExecuteNonQuery(insertQuery); // Виконання запиту
                if (result > 0)
                {
                    MessageBox.Show("Реєстрація успішна! Тепер ви можете увійти.");
                    tabControl1.SelectedTab = tabLogin; // Переходимо до вкладки "Вхід"
                }
                else
                {
                    MessageBox.Show("Помилка при реєстрації. Спробуйте ще раз.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
