using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_5_ex_1
{
//Задача 1 Создать программу, позволяющую вести список лиц, приглашенных на мероприятие.Массив должен хранить имена приглашенных.Создать консольное меню:
//1. Добавить гостя
//2. Проверить, есть ли имя гостя в списке приглашенных
//3. Исключить гостя(юзер вводит индекс)
//4. Вывести всех приглашенных
//5. Выход

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        Visitors[] arr = new Visitors[5];
            int index = 0;
            int input = 0;
            while (input != 5)
            {
                Console.WriteLine("1. Добавить гостя");
                Console.WriteLine("2. Проверить, есть ли имя гостя в списке приглашенных");
                Console.WriteLine("3. Исключить гостя");
                Console.WriteLine("4. Вывести всех приглашенных");
                Console.WriteLine("5. Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                    Console.WriteLine("введите имя госят");
                    string name = Console.ReadLine();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Visitors v = new Visitors();
                        arr[i] = v;
                        Console.WriteLine(name);
                    }
                    break;
                    case 5:
                        {
                            Console.WriteLine("Вы вышли из приложения");
                        }
                    break;
                }
            }
        }
    }
    class Visitors
    {
        public string Names;

        public void PrintVisitors()
        {
            Console.WriteLine($"{Names}");
        }
    }

