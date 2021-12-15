using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_23_var2
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialAsync();
            Proverka(10);
            Console.WriteLine("Финал");
            Console.ReadKey();
        }
        static int Proverka(int n)
        {
            Console.WriteLine("Начало проверки");            
            int m = 1;
            for (int i = 1; i < n + 1; i++)
            {
                m *= i;
                Console.WriteLine($"результат проверки: {m}");
            }
            Console.WriteLine("Конец проверки");
            return m;            
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
                Console.WriteLine($"результат факториала: {n}");
                return n;
            }
        }
        static async Task FactorialAsync()
        {
            Console.WriteLine("Вычислить факториал числа. Ввести целое число:");            
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Начало метода факториал");
            await Task.Run(() => Factorial(n));
            Console.WriteLine("Финал метода факториал");            
        }
    }
}
    

