using System;
using MySql.Data.MySqlClient;

namespace UserManagementApp
{
    class Program
    {
        // Строка підключення до бази даних
        private static string connectionString = "Server=localhost;Database=Users;User ID=root;Password=Belinskaya06.;";

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Вітаємо в системі управління користувачами!");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Зареєструвати користувача");
                Console.WriteLine("2. Перевірити, чи є користувач у базі");
                Console.WriteLine("3. Переглянути показники користувача");
                Console.WriteLine("4. Вийти");

                Console.Write("\nВиберіть дію (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterUser();
                        break;
                    case "2":
                        CheckUser();
                        break;
                    case "3":
                        ViewUserStatistics();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                        break;
                }
            }
        }

        // Функція реєстрації користувача
        private static void RegisterUser()
        {
            Console.Write("Введіть прізвище користувача: ");
            string lastName = Console.ReadLine();
            Console.Write("Введіть ім'я користувача: ");
            string name = Console.ReadLine();
            Console.Write("Введіть по батькові користувача: ");
            string middleName = Console.ReadLine();
            Console.Write("Введіть код тарифу (1, 2, 3): ");
            int codeTariff = int.Parse(Console.ReadLine());

            // Перевірка на існування тарифу
            if (codeTariff < 1 || codeTariff > 3)
            {
                Console.WriteLine("Невірний код тарифу.");
                return;
            }

            // Додаємо введення показників
            Console.Write("Введіть попередні показники (0, якщо немає): ");
            int previousReading = int.Parse(Console.ReadLine());
            Console.Write("Введіть суму боргу (0, якщо немає): ");
            decimal debt = decimal.Parse(Console.ReadLine());

            // SQL-запит для реєстрації користувача
            string query = "INSERT INTO Users.Users (LastName, Name, MiddleName, CodeTariff, PopredniPokaznyky, Zaborhovanist) VALUES (@LastName, @Name, @MiddleName, @CodeTariff, @PopredniPokaznyky, @Zaborhovanist)";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@MiddleName", middleName);
                cmd.Parameters.AddWithValue("@CodeTariff", codeTariff);
                cmd.Parameters.AddWithValue("@PopredniPokaznyky", previousReading);
                cmd.Parameters.AddWithValue("@Zaborhovanist", debt);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Користувач успішно зареєстрований.");
            }
        }


        // Функція перевірки наявності користувача
        private static void CheckUser()
        {
            Console.Write("Введіть прізвище користувача: ");
            string lastName = Console.ReadLine();
            Console.Write("Введіть ім'я користувача: ");
            string name = Console.ReadLine();
            Console.Write("Введіть по батькові користувача: ");
            string middleName = Console.ReadLine();

            string query = "SELECT COUNT(*) FROM Users.Users WHERE LastName = @LastName AND Name = @Name AND MiddleName = @MiddleName";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@MiddleName", middleName);

                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (userCount > 0)
                {
                    Console.WriteLine("Користувач знайдений у базі.");
                }
                else
                {
                    Console.WriteLine("Користувача не знайдено.");
                }
            }
        }

        // Функція для перегляду показників користувача
        private static void ViewUserStatistics()
        {
            Console.Write("Введіть прізвище користувача: ");
            string lastName = Console.ReadLine();
            Console.Write("Введіть ім'я користувача: ");
            string name = Console.ReadLine();
            Console.Write("Введіть по батькові користувача: ");
            string middleName = Console.ReadLine();

            string query = "SELECT PopredniPokaznyky, Zaborhovanist FROM Users.Users WHERE LastName = @LastName AND Name = @Name AND MiddleName = @MiddleName";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@MiddleName", middleName);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int previousReading = reader.GetInt32("PopredniPokaznyky");
                    decimal debt = reader.GetDecimal("Zaborhovanist");

                    if (previousReading == 0 && debt == 0)
                    {
                        Console.WriteLine("Показники не знайдені або не встановлені.");
                    }
                    else
                    {
                        Console.WriteLine($"Попередні показники: {previousReading}");
                        Console.WriteLine($"Борг: {debt}");
                    }
                }
                else
                {
                    Console.WriteLine("Користувача не знайдено.");
                }
            }
        }
    }
}


