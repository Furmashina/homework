using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день недели, и я покажу тебе как глубока кроличья нора ");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Понедельник":
                case "ПН":
                case "1":
                    Console.WriteLine("Сегодня Работа");
                    break;
                case "Ворник":
                    Console.WriteLine("Сегодня спорт зал");
                    break;
                case "Среда":
                    Console.WriteLine("Сегодня хобби");
                    break;
                case "Четверг":
                    Console.WriteLine("Сегодня пыво");
                    break;
                case "Пятница":
                    Console.WriteLine("Сегодня плавание");
                    break;
                case "Суббота":
                    Console.WriteLine("Сегодня обучение");
                    break;
                case "Воскресенье":
                    Console.WriteLine("Сегодня пыыыво");
                    break;
            }
            
        }
    }
}
