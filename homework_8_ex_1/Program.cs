using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_8_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Задача 1 Создать список List<double> и консольное меню:
//1.Добавить число в список
//2.Вывести числа из списка
//3.Удалить число из списка
//4.Проверить число на существование в списке
//5.Получить индекс числа из списка
//6.Выход
            List<double> list = new List<double>();
            int input = 0;
            while (input != 6)
            {
                Console.WriteLine("1.Добавить число в список");
                Console.WriteLine("2.Вывести числа из списка");
                Console.WriteLine("3.Удалить число из списка");
                Console.WriteLine("4.Проверить число на существование в списке");
                Console.WriteLine("5.Получить индекс числа из списка");
                Console.WriteLine("6.Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Зведите число в список");
                        list.Add(double.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(i + ": " + list[i]);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите, какое число следует удалить");
                        double val = double.Parse(Console.ReadLine());
                        list.Remove(val);
                        break;
                    case 4:
                        Console.WriteLine("Проверить есть ли число в списке");
                        Console.WriteLine("Введите число");
                        val = double.Parse(Console.ReadLine());
                        if (list.Contains(val))
                        {
                            Console.WriteLine("Есть");
                        }
                        else
                        {
                            Console.WriteLine("Нету");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Введите число для того чтобы узнать индекс");
                        val = double.Parse(Console.ReadLine());
                        int index = list.IndexOf(val);//Так и не понял, он мне число возвращает...
                        if (index != -1)
                        {
                            Console.WriteLine($"Индекс числа {val} = {list[index]}");
                        }
                        else
                        {
                            Console.WriteLine("Число не найдено");
                        }
                        break;
                }
            }
        }
    }
}
