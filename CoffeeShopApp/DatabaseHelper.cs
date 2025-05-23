using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CoffeeShopApp
{
    public static class DatabaseHelper
    {
        private static string connectionString = "server=localhost;user=root;password=Belinskaya06.;database=Курсова;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Виконання SELECT-запиту без параметрів
        public static DataTable ExecuteQuery(string query)
        {
            return ExecuteQuery(query, null);
        }

        // Виконання SELECT-запиту з параметрами
        public static DataTable ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}");
                return null;
            }
        }

        // Виконання INSERT/UPDATE/DELETE без параметрів
        public static int ExecuteNonQuery(string query)
        {
            return ExecuteNonQuery(query, null);
        }

        // Виконання INSERT/UPDATE/DELETE з параметрами
        public static int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}");
                return -1;
            }
        }
    }
}

