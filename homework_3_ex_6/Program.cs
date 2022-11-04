using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3_ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Задача 6 В банк на трёхпроцентный вклад положили sum рублей.Какой станет сумма вклада через n лет.
            //sum и n пользователь вводит с консоли.

            //Пример
            //Введите sum
            //1000
            //Введите количество лет
            //5
            //год 1, сумма = 1 030
            //год 2, сумма = 1 060,9
            //год 3, сумма = 1 092,73
            //год 4, сумма = 1 125,5
            //год 5, сумма = 1 159,3
            double summ = 0;
            Console.WriteLine("Введите sum");
            summ = int.Parse(Console.ReadLine());
            int i = 0;
            Console.WriteLine("Введите количество лет");
            int years = 0;
            years = int.Parse(Console.ReadLine());
            for (i = 1; i <= years; i++)
            {
                summ = (summ / 100) * 3 + summ;
                summ = Math.Round(summ, 2);
                Console.WriteLine($"Год {i}, сумма = {summ}");
            }
        }
    }
}
