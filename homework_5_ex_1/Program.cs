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
            visitors[] arr = new visitors[5];
            bool approve = false;
            int guest = 0;
            int input = 0;
            int index = 0;
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

                        Console.WriteLine("Введите имя гостя");
                        string names = Console.ReadLine();
                        visitors visitor = new visitors();
                        visitor.Names = names;
                        arr[index] = visitor;
                        index++;
                        break;
                    case 2:
                        Console.WriteLine("Введите имя гостя");
                        string name = Console.ReadLine();
                        visitor.Names = name;
                        if (visitor.Names == name)
                        {
                            approve = true;
                        }
                        if (approve)
                        {
                            Console.WriteLine("Данного типа ты уже добавил");
                        }
                    break;
                    case 3:
                        Console.WriteLine("Введите имя гостя, которого хотите удалить");


                    case 5:
                        {
                            Console.WriteLine("Вы вышли из приложения");
                        }
                    break;
                }
            }
        }
    }
    class visitors
    {
        public string Names;

        public void PrintVisitors()
        {
            Console.WriteLine($"{Names}");
        }
    }

