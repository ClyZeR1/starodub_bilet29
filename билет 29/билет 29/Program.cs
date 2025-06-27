using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace билет_29
{
    internal class Program
    {
        public static int Sum(int m, int n)
        {
            int result = 0;
            for (int i = m; i <= n; i++)
            {
                result += i;
            }
            return result;
        }

        // Объявление типа делегата
        public delegate int SumDelegate(int m, int n);

        static void Main()
        {
            // Обьявление делегата
            SumDelegate del = Sum;

            // Используем делегат три раза
            Console.WriteLine("Сумма от 1 до 5: " + del(1, 5));
            Console.WriteLine("Сумма от 10 до 15: " + del(10, 15));
            Console.WriteLine("Сумма от -3 до 3: " + del(-3, 3));

            Console.ReadLine();

            

        } 
    }
}

