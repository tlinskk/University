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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.Load += AdminForm_Load;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = $"Вітаємо, {Session.FullName} (Адміністратор)";

            dataGridViewProducts.AutoGenerateColumns = true;
            dataGridViewOrders.AutoGenerateColumns = true; 

            LoadOrders();
            LoadProducts();

            Color customBrown = Color.FromArgb(66, 37, 22);

            dataGridViewOrders.BackgroundColor = Color.Tan; // фон самої таблиці
            dataGridViewOrders.DefaultCellStyle.BackColor = Color.Tan; // фон комірок
            dataGridViewOrders.DefaultCellStyle.ForeColor = customBrown; // текст комірок

            dataGridViewOrders.EnableHeadersVisualStyles = false;
            dataGridViewOrders.ColumnHeadersDefaultCellStyle.BackColor = customBrown; // заголовки стовпців
            dataGridViewOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.Tan; // текст заголовків
            dataGridViewOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridViewOrders.RowHeadersDefaultCellStyle.BackColor = customBrown; // заголовки рядків
            dataGridViewOrders.RowHeadersDefaultCellStyle.ForeColor = customBrown;



            dataGridViewProducts.BackgroundColor = Color.Tan; // фон самої таблиці
            dataGridViewProducts.DefaultCellStyle.BackColor = Color.Tan; // фон комірок
            dataGridViewProducts.DefaultCellStyle.ForeColor = customBrown; // текст комірок

            dataGridViewProducts.EnableHeadersVisualStyles = false;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = customBrown; // заголовки стовпців
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.Tan; // текст заголовків
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridViewProducts.RowHeadersDefaultCellStyle.BackColor = customBrown; // заголовки рядків
            dataGridViewProducts.RowHeadersDefaultCellStyle.ForeColor = customBrown;

            

        }

        private void LoadOrders()
        {
            string query = @"
        SELECT 
            o.idOrders, 
            GROUP_CONCAT(p.Name SEPARATOR ', ') AS Products,
            u.Full_name, 
            o.Order_time, 
            o.Payment_method, 
            o.Comment, 
            o.IsCompleted
        FROM Orders o
        JOIN Users u ON o.User_id = u.idUsers
        LEFT JOIN OrderItems oi ON o.idOrders = oi.Order_id
        LEFT JOIN Products p ON oi.Product_id = p.idProducts
        GROUP BY o.idOrders
        ORDER BY o.Order_time DESC;";

            dataGridViewOrders.DataSource = DatabaseHelper.ExecuteQuery(query);
        }


        private void LoadProducts()
        {
            string query = "SELECT * FROM Products ORDER BY Category ASC";
            dataGridViewProducts.DataSource = DatabaseHelper.ExecuteQuery(query);

            var table = DatabaseHelper.ExecuteQuery(query);
            dataGridViewProducts.DataSource = table;

            MessageBox.Show($"Знайдено товарів: {table.Rows.Count}");



        }

        private void buttonMarkCompleted_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["idOrders"].Value);

                string query = $"UPDATE Orders SET IsCompleted = 1 WHERE idOrders = {orderId}";
                DatabaseHelper.ExecuteNonQuery(query);

                MessageBox.Show("Замовлення позначено як виконане.");
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Оберіть замовлення зі списку.");
            }
        }




        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text.Trim();
            string description = textBoxDescription.Text.Trim();
            string category = textBoxCategory.Text.Trim();
            decimal price;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(category) ||
                !decimal.TryParse(textBoxProductPrice.Text, out price))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля коректно.");
                return;
            }

            string query = "INSERT INTO Products (Name, Description, Category, Price) VALUES (@Name, @Description, @Category, @Price)";
            var parameters = new Dictionary<string, object>
    {
        { "@Name", name },
        { "@Description", description },
        { "@Category", category },
        { "@Price", price }
    };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Товар успішно додано.");
                LoadProducts();
                // Очищення полів після додавання
                textBoxProductName.Clear();
                textBoxDescription.Clear();
                textBoxCategory.Clear();
                textBoxProductPrice.Clear();
            }
            else
            {
                MessageBox.Show("Сталася помилка при додаванні товару.");
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["idProducts"].Value);
                string query = $"DELETE FROM Products WHERE idProducts = {productId}";
                DatabaseHelper.ExecuteNonQuery(query);

                MessageBox.Show("Товар видалено.");
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Оберіть товар для видалення.");
            }
        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button1Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете вийти з програми?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1Back_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // або this.Close(); якщо не плануєш повертатись
        }
    }
}
