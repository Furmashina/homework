using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homework_3_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3 Каждый месяц магазин зарабатывает прибыль в диапазоне от[1000; 3000] рублей.
            //Используйте Random для генерации случайного числа в этом диапазоне.
            //Найдите среднии доход магазина за год.
            //Для этого нужно сложить прибыли магазина за 12 месяцев и поделить общую прибыль на 12.

            int month = 0;
            int money = 0;
            double summ = 0;
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                money = random.Next(1000, 3000);
                month += 1;
                Console.WriteLine($"За {month} месяц, прибыль составила - {money} рублей");
                summ += money;
            }

            Console.WriteLine("Прибыль за 12 месяцев, составила " + summ / 12);
        }
    }
}
