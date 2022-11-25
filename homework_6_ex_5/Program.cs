using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1 Создать класс Passport с полями
            //В мейне создайте три объекта класса Passport, не используя циклов, значения для каждого вводите с консоли.
            //Вы могли заметить, что это довольно долгий процесс.
            //Поэтому создайте конструктор с параметрами для каждого поля класса и замените код в мейне на новый, задействовав конструктор.
            Passport[] pass = new Passport[5];
            int index = 0;
            Console.WriteLine("Введите данные паспорта");
            pass[index++] = new Passport(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
    }
}
