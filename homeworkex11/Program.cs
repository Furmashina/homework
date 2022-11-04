using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название месяца");
            string month = Console.ReadLine();
            switch (month)
            {
                case "июнь":
                case "июль":
                case "август":
                     Console.WriteLine("Эт лето");
                    break;
                case "сентябрь":
                case "октябрь":
                case "ноябрь":
                    Console.WriteLine("Эт осень");
                    break;
                case "декабрь":
                case "январь":
                case "февраль":
                    Console.WriteLine("Эт зима");
                    break;
                case "март":
                case "апрель":
                case "май":
                    Console.WriteLine("Эт весна");
                    break;
            }
        }
    }
}
