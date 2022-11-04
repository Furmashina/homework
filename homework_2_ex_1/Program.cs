using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2 Создать простую программу калькулятор с консольным меню:
            //1.Сложить
            //2.Вычесть
            //3.Умножить
            //4.Делить
            //5.Выход
            //При делении нужно следить, чтобы не было деления на ноль.Программа должна завершаться только при выборе пункта 5.
            string up1 = "0";
            string input = " ";
            bool Enter = false;
            while (input != "5")
            {
                if (!Enter)
                {
                    Console.WriteLine("Чтобы посмотреть функции программы, введите - Посмотреть");
                    Console.WriteLine("Для выхода, нажмите 5");
                }
                else
                {
                    Console.WriteLine("1.Выполнить сложение");
                    Console.WriteLine("2.Выполнить вычитание");
                    Console.WriteLine("3.Выполнить умножение");
                    Console.WriteLine("4.Выполнить деление");
                    Console.WriteLine("5.Выйти из программы");
                }
                input = Console.ReadLine();
                switch (input)
                {
                    case "Посмотреть":
                        Console.WriteLine("Вы попали в калькулятор, для просмотра функций введите - 0");
                        string up = Console.ReadLine();
                        if (up == up1)
                        {
                            Console.WriteLine("Приятного пользования!");
                            Enter = true;
                        }
                        else
                        {
                            Console.WriteLine("Как-нибудь в другой раз...");
                        }
                        break;
                    case "1":
                        Console.Write("Введите число 1 ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write("Введите чило 2 ");
                        int y = int.Parse(Console.ReadLine());
                        Console.WriteLine(x + y);
                        break;
                    case "2":
                        Console.Write("Введите число 1 ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Введите число 2 ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine(a - b);
                        break;
                    case "3":
                        Console.Write("Введите число 1 ");
                        int c = int.Parse(Console.ReadLine());
                        Console.Write("Введите число 2 ");
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine(c * d);
                        break;
                    case "4":
                        Console.Write("Введите число 1 ");
                        int q = int.Parse(Console.ReadLine());
                        Console.Write("Введите число 2 ");
                        int w = int.Parse(Console.ReadLine());
                        if (q == 0 || w == 0)
                        {
                            Console.WriteLine("Делить на 0 нельзя!");
                        }
                        else
                        {
                            Console.WriteLine(q / w);
                        }
                        break;
                }
            }
        }
    }
}
