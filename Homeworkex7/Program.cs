using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Задача 7 Определить, совпадают ли имя, фамилия и отчество двух людей.
            //Пользователь вводит по отдельности с консоли имя, фамилию, отчество для первого человека, потом для второго. Программа выводит ответ - совпадают или нет.
            Console.Write("Введите ФИО первого человека");
            string first = Console.ReadLine();
            Console.Write("Введите ФМО второго человека");
            string second = Console.ReadLine();
            if (first == second)
            {
                Console.WriteLine("Мем с человеком пауком");
            }
            else
            {
                Console.WriteLine("Неть, вы не совпадаете");
            }
        }
    }
}
