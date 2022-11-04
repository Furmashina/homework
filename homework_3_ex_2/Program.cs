using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homework_3_ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2 Пользователь вводит с консоли 5 чисел, найти максимальное среди них

            int max = 0;
            Console.WriteLine("Введите 5 чисел");
            for (int i = 0; i <5 ; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > max)
                {
                    max = x;
                }
            }
            Console.WriteLine("Максимальное веденное чилсо = "+ max);
        }
    }
}
