using System;
using System.Collections.Generic;
using System.Xml;

namespace CaffeMenuApp
{
    // Статичний клас для зберігання та роботи з меню
    class CaffeMenu
    {
        public static List<Food> FoodsList = new List<Food>();

        // Метод для додавання елементів у список меню
        public static void Add(Food food)
        {
            FoodsList.Add(food);
        }

        // Метод для виведення меню на екран
        public static void Show()
        {
            foreach (Food food in FoodsList)
            {
                food.PrintToConsole();
            }
        }
    }

    // Клас для представлення страви
    class Food
    {
        public string Name { get; private set; }
        public string Price { get; private set; }
        public string Description { get; private set; }
        public int Calories { get; private set; }

        // Конструктор для ініціалізації властивостей страви
        public Food(string name, string price, string description, int calories)
        {
            Name = name;
            Price = price;
            Description = description;
            Calories = calories;
        }

        // Метод для виведення інформації про страву на консоль
        public void PrintToConsole()
        {
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Цiна: {Price}");
            Console.WriteLine($"Опис: {Description}");
            Console.WriteLine($"Калорiї: {Calories}");
            Console.WriteLine();
        }
    }

    // Головний клас програми
    class Program
    {
        static void Main(string[] args)
        {
            // Завантаження XML-документа
            XmlDocument xml = new XmlDocument();
            xml.Load(@"C:\Users\User\OneDrive\Рабочий стол\XMLFile7.xml"); // Вкажіть правильний шлях до вашого XML-файлу

            // Перебір елементів "food" у XML-документі
            foreach (XmlNode node in xml.DocumentElement)
            {
                if (node.Name == "food")
                {
                    var name = node["name"]?.InnerText;
                    var price = node["price"]?.InnerText;
                    var description = node["description"]?.InnerText;
                    var calories = int.Parse(node["calories"]?.InnerText ?? "0");

                    // Перевірка наявності обов'язкових полів перед створенням об'єкта
                    if (name != null && price != null && description != null)
                    {
                        Food food = new Food(name, price, description, calories);
                        CaffeMenu.Add(food);
                    }
                }
            }

            // Виведення меню на консоль
            CaffeMenu.Show();
        }
    }
}