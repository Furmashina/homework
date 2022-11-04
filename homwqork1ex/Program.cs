using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homwqork1ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2 Написать программу упражнений в тренажерном зале. Если пользователь ввел с консоли слово "Понедельник",
            //программа должна вывести на консоль текст "Сегодня тренировка ног". Сделать проверки на остальные дни, если:
            //Вторник - тренировка рук
            //Среда - тренировка спины
            //Четверг - кардио
            //Пятница - тренировка плеч
            //Суббота - выходной
            //Воскресенье - прогулка
            //все остальное -некорректный ввод

            Console.WriteLine("Program of working");
            string DayOfWeek = Console.ReadLine();
            switch (DayOfWeek)
            {
                case "monday":
                    Console.WriteLine("Today we working our legs");
                    break;
                case "thuesday":
                    Console.WriteLine("Today we working our arms");
                    break ;
                case "wednesday":
                    Console.WriteLine("Today we working our back");
                    break;
                case "thursday":
                    Console.WriteLine("Today we working cardio");
                    break;
                case "friday":
                    Console.WriteLine("Today we working our shoulder");
                    break;
                case "saturday":
                    Console.WriteLine("Finaly! we can chill!");
                    break;
                case "sunday":
                    Console.WriteLine("We go to walk");
                    break;
                    default:
                    Console.WriteLine("Error to system, pls call me");
                    break;
            }
        
        }

    }
}
