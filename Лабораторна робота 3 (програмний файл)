using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = null;

            Console.WriteLine("Виберiть метод заповнення масиву:");
            Console.WriteLine("1. Введення з клавiатури");
            Console.WriteLine("2. Введення з файлу");
            Console.WriteLine("3. Заповнення випадковими числами");
            Console.Write("Ваш вибiр (1/2/3): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    array = InputFromKeyboard();
                    break;
                case 2:
                    array = InputFromFile();
                    break;
                case 3:
                    array = InputRandomNumbers();
                    break;
                default:
                    Console.WriteLine("Неправильний вибiр.");
                    return;
            }

            Console.WriteLine("Масив перед обмiном:");
            PrintArray(array);

            SwapFirstAndLastPositive(array);

            Console.WriteLine("Масив пiсля обмiну:");
            PrintArray(array);
        }

        static int[] InputFromKeyboard()
        {
            Console.Write("Введiть розмiр масиву: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Елемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        static int[] InputFromFile()
        {
            Console.Write("Введіть шлях до файлу: ");
            string filePath = Console.ReadLine();
            string[] lines = File.ReadAllLines(filePath);
            int[] array = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                array[i] = int.Parse(lines[i]);
            }

            return array;
        }

        static int[] InputRandomNumbers()
        {
            Console.Write("Введiть розмiр масиву: ");
            int size = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(-100, 101); // Випадкові числа від -100 до 100
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Масив:");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

        static void SwapFirstAndLastPositive(int[] array)
        {
            int firstIndex = -1;
            int lastIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (firstIndex == -1)
                    {
                        firstIndex = i;
                    }
                    lastIndex = i;
                }
            }

            if (firstIndex != -1 && lastIndex != -1 && firstIndex != lastIndex)
            {
                int temp = array[firstIndex];
                array[firstIndex] = array[lastIndex];
                array[lastIndex] = temp;
            }
            else
            {
                Console.WriteLine("Не вдалося знайти два додатнi елементи для обмiну.");
            }
        }
    }
}


