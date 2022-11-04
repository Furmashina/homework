using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace homeworkex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи параметры");
            Console.WriteLine("Введите количество оперативной памяти");
            int memory = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип экрана");
            string wind = Console.ReadLine();
            Console.WriteLine("Введите желательную цену");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество ядер процессора");
            int cp = int.Parse(Console.ReadLine());
            if ((memory == 8 || memory == 16) && (wind == "IPS" || wind == "LED") && price < 50000 && (cp == 4 || cp == 8))
            {
                Console.WriteLine("Оно нам подходит");
            }    
            else
            {
                Console.WriteLine("Не бери это говно");
            }

        }
    }
}
