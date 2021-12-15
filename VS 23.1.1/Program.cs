using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_23._1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int r = FactorialAsync().Result;              
            Proverka();
            Console.WriteLine("Финал");
            Console.ReadKey();
        }
        static void Proverka()
        {
            Console.WriteLine("\nДля проверки ввести целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            for (int i = 1; i < n + 1; i++)
            {
                m *= i;
                Console.WriteLine($"результат: {m}");
            }
            Console.WriteLine($"Итого {m}");
        }
        static int Factorial(int x)
        {
            int n = 0;
            if (x == 0)
            {
                return 1;
            }
            else
            {
                n = x * Factorial(x - 1);
                Console.WriteLine($"результат: {n}");
                return n;
            }

        }
        static async Task<int> FactorialAsync()
        {
            Console.WriteLine("Вычислить факториал числа. Ввести целое число:");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = await Task.Run(() => Factorial(n));
            Console.WriteLine($"Итого: {result}");
            return result;
        }
    }
}