using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CoffeeShopApp
{
    public partial class UserForm : Form
    {
        private List<Product> cart = new List<Product>();
        public UserForm()
        {
            InitializeComponent();
        }




        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadProductList();
            InitializeDataGridViewCart();  // Ініціалізуємо dataGridViewCart
            LoadPreviousOrders();  // Завантажуємо попередні замовлення

            Color customBrown = Color.FromArgb(66, 37, 22);

            dataGridViewProducts.BackgroundColor = Color.Tan; // фон самої таблиці
            dataGridViewProducts.DefaultCellStyle.BackColor = Color.Tan; // фон комірок
            dataGridViewProducts.DefaultCellStyle.ForeColor = customBrown; // текст комірок

            dataGridViewProducts.EnableHeadersVisualStyles = false;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = customBrown; // заголовки стовпців
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.Tan; // текст заголовків
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridViewProducts.RowHeadersDefaultCellStyle.BackColor = customBrown; // заголовки рядків
            dataGridViewProducts.RowHeadersDefaultCellStyle.ForeColor = customBrown;





            dataGridViewCart.BackgroundColor = Color.Tan; // фон самої таблиці
            dataGridViewCart.DefaultCellStyle.BackColor = Color.Tan; // фон комірок
            dataGridViewCart.DefaultCellStyle.ForeColor = customBrown; // текст комірок

            dataGridViewCart.EnableHeadersVisualStyles = false;
            dataGridViewCart.ColumnHeadersDefaultCellStyle.BackColor = customBrown; // заголовки стовпців
            dataGridViewCart.ColumnHeadersDefaultCellStyle.ForeColor = Color.Tan; // текст заголовків
            dataGridViewCart.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridViewCart.RowHeadersDefaultCellStyle.BackColor = customBrown; // заголовки рядків
            dataGridViewCart.RowHeadersDefaultCellStyle.ForeColor = customBrown;



            dataGridViewPreviousOrders.BackgroundColor = Color.Tan; // фон самої таблиці
            dataGridViewPreviousOrders.DefaultCellStyle.BackColor = Color.Tan; // фон комірок
            dataGridViewPreviousOrders.DefaultCellStyle.ForeColor = customBrown; // текст комірок

            dataGridViewPreviousOrders.EnableHeadersVisualStyles = false;
            dataGridViewPreviousOrders.ColumnHeadersDefaultCellStyle.BackColor = customBrown; // заголовки стовпців
            dataGridViewPreviousOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.Tan; // текст заголовків
            dataGridViewPreviousOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridViewPreviousOrders.RowHeadersDefaultCellStyle.BackColor = customBrown; // заголовки рядків
            dataGridViewPreviousOrders.RowHeadersDefaultCellStyle.ForeColor = customBrown;

        }




        private void InitializeDataGridViewCart()
        {
            DataTable cartTable = new DataTable();
            cartTable.Columns.Add("ProductName", typeof(string));
            cartTable.Columns.Add("Price", typeof(decimal));
            cartTable.Columns.Add("Quantity", typeof(int));

            dataGridViewCart.DataSource = cartTable;

            // Зміна заголовків колонок на українську
            dataGridViewCart.Columns["ProductName"].HeaderText = "Назва";
            dataGridViewCart.Columns["Price"].HeaderText = "Ціна";
            dataGridViewCart.Columns["Quantity"].HeaderText = "Кількість";

        }




        private void LoadProductList()
        {
            // Запит для отримання всіх товарів
            string query = "SELECT * FROM Products ORDER BY Category ASC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            // Встановлюємо джерело даних для DataGridView
            dataGridViewProducts.DataSource = dt;

            dataGridViewProducts.Columns["idProducts"].Visible = false;

            dataGridViewProducts.Columns["Name"].HeaderText = "Назва";
            dataGridViewProducts.Columns["Description"].HeaderText = "Опис";
            dataGridViewProducts.Columns["Category"].HeaderText = "Категорія";
            dataGridViewProducts.Columns["Price"].HeaderText = "Ціна"; 

        }



        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                // Отримуємо дані про вибраний товар
                var selectedRow = dataGridViewProducts.SelectedRows[0];
                string productName = selectedRow.Cells["Name"].Value.ToString();
                AddToCart(productName);
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть товар для додавання в корзину.");
            }
        }






        private void AddToCart(string productName)
        {
            // Отримуємо ProductId через назву товару
            int productId = GetProductIdByName(productName);

            if (productId == 0)
            {
                MessageBox.Show("Товар не знайдений в базі даних.");
                return;
            }

            // Створити об'єкт Product для вибраного товару
            Product product = new Product
            {
                ProductId = productId,
                ProductName = productName,
                Price = GetProductPrice(productId)  // Отримуємо ціну товару
            };

            // Додаємо товар до корзини
            cart.Add(product);

            // Додаємо товар в dataGridViewCart
            DataTable cartTable = (DataTable)dataGridViewCart.DataSource;

            if (cartTable == null)
            {
                // Створюємо нову таблицю, якщо це перший товар у кошику
                cartTable = new DataTable();
                cartTable.Columns.Add("ProductName", typeof(string));
                cartTable.Columns.Add("Price", typeof(decimal));
                cartTable.Columns.Add("Quantity", typeof(int));

                dataGridViewCart.DataSource = cartTable;
            }

            DataRow newRow = cartTable.NewRow();
            newRow["ProductName"] = product.ProductName;
            newRow["Price"] = product.Price;
            newRow["Quantity"] = 1;  // Додаємо товар з кількістю 1 (можна змінювати кількість)
            cartTable.Rows.Add(newRow);

            MessageBox.Show($"Товар {product.ProductName} додано до корзини!");
        }




        private int GetProductIdByName(string productName)
        {
            int productId = 0;

            // Створюємо з'єднання з базою даних
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT idProducts FROM Products WHERE Name = @productName";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productName", productName);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        productId = Convert.ToInt32(result);
                    }
                }
            }

            return productId;
        }





        private decimal GetProductPrice(int productId)
        {
            decimal price = 0;

            // Створюємо з'єднання з базою даних для отримання ціни
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT Price FROM Products WHERE idProducts = @productId";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        price = Convert.ToDecimal(result);
                    }
                }
            }

            return price;
        }



        private void LoadPreviousOrders()
        {
            // SQL запит для отримання даних про попередні замовлення
            string query = @"
        SELECT 
            o.Order_time, 
            p.Name AS ProductName, 
            o.IsCompleted
        FROM Orders o
        JOIN OrderItems oi ON o.idOrders = oi.Order_id
        JOIN Products p ON oi.Product_id = p.idProducts
        WHERE o.User_id = @UserId
        ORDER BY o.Order_time DESC";

            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                    DataTable dt = new DataTable();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    // Додаємо текстову колонку "Статус"
                    dt.Columns.Add("Статус", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["Статус"] = (bool)row["IsCompleted"] ? "Так" : "Ні";
                    }

                    // Ховаємо технічну колонку
                    dt.Columns["IsCompleted"].ColumnMapping = MappingType.Hidden;

                    dataGridViewPreviousOrders.DataSource = dt;

                    // Налаштовуємо заголовки
                    dataGridViewPreviousOrders.Columns["ProductName"].HeaderText = "Назва товару";
                    dataGridViewPreviousOrders.Columns["Order_time"].HeaderText = "Час замовлення";
                    dataGridViewPreviousOrders.Columns["Статус"].HeaderText = "Виконано";
                }
            }
        }











        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Ваша корзина порожня. Додайте товари перед оформленням замовлення.");
                return;
            }

            // Створення рядка для відображення вмісту кошика
            string cartDetails = "Ваша корзина:\n";
            decimal totalAmount = 0;

            foreach (var product in cart)
            {
                cartDetails += $"{product.ProductName} - {product.Price} грн\n";
                totalAmount += product.Price;
            }

            cartDetails += $"\nЗагальна сума: {totalAmount} грн";

            // Запитуємо користувача, який метод оплати вибрано
            DialogResult paymentResult = MessageBox.Show(
                "Виберіть метод оплати: \nГотівка(Yes) або Картка(No)",
                "Вибір методу оплати",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            string paymentMethod = "";

            if (paymentResult == DialogResult.Yes)
            {
                paymentMethod = "Картка";  // Якщо вибрано "Yes" (наприклад, це Картка)
            }
            else
            {
                paymentMethod = "Готівка";  // Якщо вибрано "No" (наприклад, це Готівка)
            }

            // Отримуємо коментар від користувача
            string comment = txtComment.Text;


            // Показуємо вміст кошика та загальну суму
            DialogResult result = MessageBox.Show(cartDetails + "\nБажаєте підтвердити замовлення?", "Підтвердження замовлення", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Якщо користувач підтверджує замовлення, ми можемо зберегти замовлення в базі даних

                // Зберігаємо замовлення у таблиці Orders
                string insertOrderQuery = "INSERT INTO Orders (User_id, Order_time, Payment_method, Comment) VALUES (@UserId, NOW(), @PaymentMethod, @Comment)";
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(insertOrderQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", Session.UserId);  // Використовуємо User_id з сесії
                        cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);  // Вибраний метод оплати
                        cmd.Parameters.AddWithValue("@Comment", comment );  // Можна змінити на значення з TextBox або іншого елемента UI
                        cmd.ExecuteNonQuery();
                    }
                }

                // Тепер, після виконання запиту на додавання замовлення, отримаємо ID останнього замовлення
                int orderId = 0;
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string getLastInsertIdQuery = "SELECT LAST_INSERT_ID()";
                    using (var cmd = new MySqlCommand(getLastInsertIdQuery, connection))
                    {
                        orderId = Convert.ToInt32(cmd.ExecuteScalar()); // Отримуємо ID останнього замовлення
                    }
                }

                // Тепер зберігаємо кожен товар у таблиці OrderItems
                foreach (var product in cart)
                {
                    string insertOrderItemQuery = "INSERT INTO OrderItems (Order_id, Product_id, Quantity, Price) VALUES (@Order_id, @Product_id, @Quantity, @Price)";
                    using (var connection = DatabaseHelper.GetConnection())
                    {
                        connection.Open();
                        using (var cmd = new MySqlCommand(insertOrderItemQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@Order_id", orderId);  // ID замовлення
                            cmd.Parameters.AddWithValue("@Product_id", product.ProductId);  // Назва товару
                            cmd.Parameters.AddWithValue("@Quantity", 1);  // Кількість одинична
                            cmd.Parameters.AddWithValue("@Price", product.Price);  // Ціна товару
                            cmd.ExecuteNonQuery();  // Виконуємо запит для кожного товару
                        }
                    }
                }

                MessageBox.Show("Ваше замовлення успішно оформлено!");
                cart.Clear(); // Очищення кошика після оформлення замовлення
                txtComment.Clear(); // Очищення тексту в полі коментаря
            }
        }




        private void CustomizeGrid()
        {
            dataGridViewPreviousOrders.Columns["Order_time"].HeaderText = "Час замовлення";
            dataGridViewPreviousOrders.Columns["ProductName"].HeaderText = "Назва продукту";

            // Можна також налаштувати формат відображення часу, якщо потрібно
            dataGridViewPreviousOrders.Columns["Order_time"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }




        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();  // Отримуємо введений текст у полі пошуку

            // Перевіряємо, чи є текст у полі пошуку
            if (!string.IsNullOrEmpty(searchText))
            {
                // Запит для отримання товарів, що містять введений текст у назві
                string query = "SELECT * FROM Products WHERE LOWER(Name) LIKE @searchText";

                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                        // Заповнюємо DataTable з результатами запиту
                        DataTable dt = new DataTable();
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        // Встановлюємо нові дані в DataGridView
                        dataGridViewProducts.DataSource = dt;
                    }
                }
            }
            else
            {
                // Якщо поле пошуку порожнє, завантажуємо всі продукти з бази даних
                LoadProductList();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете вийти з програми?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // або this.Close(); якщо не плануєш повертатись
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewCart.SelectedRows[0].Index;
                string productName = dataGridViewCart.SelectedRows[0].Cells["ProductName"].Value.ToString();

                // Видалення з DataGridView
                DataTable cartTable = (DataTable)dataGridViewCart.DataSource;
                cartTable.Rows.RemoveAt(selectedIndex);

                // Видалення з списку cart
                var productToRemove = cart.FirstOrDefault(p => p.ProductName == productName);
                if (productToRemove != null)
                {
                    cart.Remove(productToRemove);
                }

                MessageBox.Show($"Товар {productName} видалено з корзини.");
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть товар для видалення.");
            }
        }
    }
}
