using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3 Создать консольное меню, которое позволит пользователю решать любое уравнение на выбор столько раз, сколько ему нужно
            //1.a + b =?
            //2. 2 * a - b = ?
            //3. (a + b + с) * 2 = ?
            //4.Выход
            //При выборе пунктов 1 - 3 программа запрашивает с консоли значения для переменных из уравнения и выводит результат.
            //Программа должна завершаться при выборе пункта 4.
            
            string input = " ";
            bool Enter = false;
            while (input != "4")
            {
                if (!Enter)
                {
                    Console.WriteLine("Для решения уравнений, введите 0");
                    Console.WriteLine("Для выхода, нажмите 4");
                }
                else
                {
                    Console.WriteLine("1.a + b = ? ");
                    Console.WriteLine("2.2 * a - b = ? ");//тут точно скобочек не надо?) 
                    Console.WriteLine("3.(a + b + c) * 2 = ? ");
                    Console.WriteLine("4.Выход из программы");
                }
                input = Console.ReadLine();
                switch (input)
                {

                    case "0":
                        if (input == "0")
                        {
                            Console.WriteLine("Введите команду, которую хотите получить");
                            Enter = true;
                        }
                        else
                        {
                            Console.WriteLine("Для выхода, нажмите 4");
                            Enter = false;
                        }
                        break;
                    case "1":
                        Console.WriteLine("Введите a переменную");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите b переменную");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine(a + b);
                        break;
                    case "2":
                        Console.WriteLine("Введите a переменную");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите b переменную");
                        int y = int.Parse(Console.ReadLine());
                        Console.WriteLine(2 * x - y);
                        break;
                    case "3":
                        Console.WriteLine("Введите a переменную");
                        int q = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите b переменную");
                        int w = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите c переменную");
                        int e = int.Parse(Console.ReadLine());
                        Console.WriteLine((q + w + e) * 2);
                        break;
                }
            }
        }
    }
}
