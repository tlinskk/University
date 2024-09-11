using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр2.ООП
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(15, 56));
                Console.Write("{0} ", chisla[i]);
            }
            for (int i=0; i < chisla.Count; i++)
            {
                if (chisla[i]%3==0 || chisla[i]% 5 == 0)
                {
                    chisla.RemoveAt(i);
                    break;
                }
            }
            Console.Write("\nКолекцiя пiсля видалення першого числа, кратного 3 або 5: ");
            foreach (int num in chisla)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            Console.ReadKey(); */

            /* Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(5, 51));
            }
            Console.WriteLine("Початковий список:");
            foreach (int num in chisla)
            {
                Console.Write("{0} ", num);
            }
            Console.Write("\n\nВведiть число X: ");
            int X = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < chisla.Count; i++)
            {
                if (chisla[i] < X)
                {
                    chisla.Insert(i, X);
                    i++; 
                }
            }
            Console.WriteLine("\nМодифiкований список:");
            foreach (int num in chisla)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine();
            Console.ReadKey();*/

            Random random = new Random();
            List<int> numbers = new List<int>();
            List<int> multiplesOfThree = new List<int>();
            List<int> notMultiplesOfThree = new List<int>();

            Console.Write("Введiть кiлькiсть чисел (N): ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int randomNumber = random.Next(10, 100); 
                numbers.Add(randomNumber);
            }
            foreach (int number in numbers)
            {
                if (number % 3 == 0)
                {
                    multiplesOfThree.Add(number); 
                }
                else
                {
                    notMultiplesOfThree.Add(number); 
                }
            }
            Console.WriteLine("\nПочаткова колекцiя чисел:");
            Console.WriteLine(string.Join(" ", numbers));

            Console.WriteLine("\nЧисла, кратнi 3:");
            Console.WriteLine(string.Join(" ", multiplesOfThree));

            Console.WriteLine("\nРешта чисел:");
            Console.WriteLine(string.Join(" ", notMultiplesOfThree));

        }
        }
    }

