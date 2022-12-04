using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //В мейне создайте массив на 5 Laptop, заполните его случайными значениями.
            //Для ram используйте диапазоне от 4 до 32
            //Для cores используйте диапазоне от 1 до 8
            //Для videoRam используйте диапазоне от 1 до 4
            //Создайте консольное меню:
            //1.Вывести все видеокарты
            //2.Посчитать fps ноутбука под индексом x
            //3.Прокачать ноутбук под индексом x(юзер вводит x и новое значение для cores и videoRam)
            //4.Найти самую мощный ноутбук по значению fps(нужно найти целиком объект и вывести его поля на консоль)
            //5.Выход
            LaptopCard[] laptop = new LaptopCard[5];
            Random rnd = new Random();
            int index = 0;
            int input = 0;
            for (int i = 0; i < laptop.Length; i++)
            {
                laptop[index++] = new LaptopCard(rnd.Next(4, 32), rnd.Next(1, 8), rnd.Next(1,4));
            }
            while (input != 5)
            {
                Console.WriteLine("1.Вывести все видеокарты");
                Console.WriteLine("2.Посчитать fps ноутбука");
                Console.WriteLine("3.Прокачать ноутбук");
                Console.WriteLine("4.Найти самую мощный ноутбук по значению fps");
                Console.WriteLine("5.Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        for (int i = 0; i < laptop.Length; i++)
                        {
                            laptop[i].PrintInfo();
                        }
                        break;
                    case 2:
                        //2.Посчитать fps ноутбука под индексом x
                        //bool approve = false;
                        Console.WriteLine("Напишите индекс ноутбука, для подсчёта FPS");
                        int indexFps = int.Parse(Console.ReadLine());
                        int fps = laptop[indexFps].CalcFPS();
                        Console.WriteLine(fps);
                     
                        break;
                    case 3:
                        //3.Прокачать ноутбук под индексом x(юзер вводит x и новое значение для cores и videoRam)
                        Console.WriteLine("Введите индекс ноутбука");
                        int indexLaptop = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите новое значение для cores");
                        int newCores = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите новое значение для videoRam");
                        int newVideoRam = int.Parse(Console.ReadLine());
                        laptop[indexLaptop].Cores = newCores;
                        laptop[indexLaptop].VideoRam = newVideoRam;
                        break;
                    case 4:
                        int maxFPS = 0;
                        for (int i = 0; i < laptop.Length; i++)
                        {
                            if (maxFPS > laptop[i].CalcFPS())
                            {
                                maxFPS = laptop[i].CalcFPS();
                            }
                        }
                        Console.WriteLine($"Самый мощный фпс в ноутбуке  его фпс составляет {laptop[maxFPS].CalcFPS()}");
                        break;
                }
            }
        }
    }
}
