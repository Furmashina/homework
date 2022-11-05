using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4_ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 8 Создать массив, хранящий паспортные данные пользователя.Допустим паспорт содержит данные:
            //серия, номер и имя.
            //Необходимо создать три массива, которые будут хранить данные паспорта.
            //Данные в массивах должны храниться таким образом, чтобы данные одного паспорта хранились под одинаковым индексом во всех массивах.
            //В мейне создать консольное меню:
            //1.Добавить паспорт
            //2.Вывести все паспорта
            //3.Удалить паспорт
            //4.Проверить паспорт на существование
            //5.Выход
            string[] ser = new string[5];
            string[] numb = new string[5];
            string[] name = new string[5];
            int index = 0;
            int input = 0;
            while (input != 5)
            {
                Console.WriteLine("1.Добавить паспорт");
                Console.WriteLine("2.Вывести все паспорта");
                Console.WriteLine("3.Удалить паспорт");
                Console.WriteLine("4.Проверить паспорт на существование");
                Console.WriteLine("5.Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Введите серию паспорта");
                        string ser1 = Console.ReadLine();
                        for (int i = 0; i < ser.Length; i++)
                        {
                            ser[i] = ser1;
                            index++;
                        }
                        Console.WriteLine("Введите номер паспорта");
                        string numb1 = Console.ReadLine();
                        for (int i = 0; i < numb.Length; i++)
                        {
                            numb[i] = numb1;
                            index++;
                        }
                        Console.WriteLine("Введите Имя");
                        string name1 = Console.ReadLine();
                        for (int i = 0; i < name.Length; i++)
                        {
                            name[i] = name1;
                            index++;
                        }
                        break;
                        case 2:
                        for (int i = 0; i < pass.Length; i++)
                        {
                               
                        }
                        break;
                }
            }
        }
    }
}
