using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3_ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 4 Петя работает фермером.Его прибыль зависит от урожая.Но каждый год почва дает разный урожай, соответственно, каждый год у Пети разный доход.
            //Определите, какой был максимальный доход Пети за 5 лет, если каждый год почва может дать[100; 200] кг урожая.
            //За каждый киллограмм урожая Петя получает 100 рублей.

            //Пример того, как должна работать программа:
            //            Год 1, урожая 120 кг, доход пети 12000 руб.
            //            Год 2, урожая 110 кг, доход пети 11000 руб.
            //            Год 3, урожая 160 кг, доход пети 16000 руб.
            //            Год 4, урожая 180 кг, доход пети 18000 руб.
            //            Год 5, урожая 115 кг, доход пети 11500 руб.
            //Максимальный доход Пети был 18000 руб.
            int money = 100;
            int dohod = 0;
            int kg = 0;
            int max = 0;
            Random rnd = new Random();
            for (int year = 1; year < 6; year++)
            {
                kg = rnd.Next(100, 200);
                dohod = money * kg;
                if (dohod > max)
                {
                    max = dohod;
                }
                Console.WriteLine($"Год {year} урожая {kg}, доход Пети {dohod}");
            }
            Console.WriteLine($"Максимальный доход Пети = {max}");

        }
    }
}
