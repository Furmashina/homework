using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homeework_3_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1 Сгенерировать 5 случайных чисел в диапазоне от 10 до 20 и найти максимальное, минимальное среди них и сумму чисел


            int min = 20;
            int max = 0;
            int sum = 0;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int x = random.Next(10, 20);
                Console.WriteLine(x);
                if (x > max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }
                sum = max + min;

            }
                Console.WriteLine("max = " + max);
                Console.WriteLine("min = " + min);
                Console.WriteLine("sum = " + sum);
        }
    }
}
