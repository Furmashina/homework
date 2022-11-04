
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 6 Сделать список покупок на 5 элементов в виде массива.
            //Создать консольное меню:
            //1.Добавить покупку(юзер вводит название покупки.Новую покупку можно добавить только, если ее еще нет в списке)
            //2.Вывести список покупок(все элементы, кроме null)
            //3.Вывести на консоль количество добавленных покупок(то есть результатом должно быть одно число - кол - во не null покупок)
            //4.Удалить покупку(юзер вводит индекс и нужно приравнять значение под индексом к null)
            //5.Выход
            string[] arr = new string[5];
            int input = 0;
            int size = 0;
            Console.WriteLine("Выберите пункт");
            while (input != 5)
            {
                    Console.WriteLine("1.Добавить покупку");
                    Console.WriteLine("2.Вывести список покупок");
                    Console.WriteLine("3.Вывести количество добавленных покупок");
                    Console.WriteLine("4.Удалить покупку");
                    Console.WriteLine("5.Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Внесите покупку в список");
                        string buy = Console.ReadLine();
                        bool isExist = true;
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (buy == arr[i])
                            {
                                isExist = false;
                            }
                        }
                        if (isExist)
                        {
                            arr[size] = buy;
                            size++;
                            Console.WriteLine("Покупка добавлена");
                        }
                        else
                        {
                            Console.WriteLine("Покупка уже существует");
                        }
                        break;
                    case 2:
                        for (int i = 0; i < size; i++)
                        {
                            Console.WriteLine(arr[i]);
                        }
                        break;
                    case 3:
                        Console.WriteLine(size);
                        break;
                    case 4:
                        Console.Write("enter index: ");
                        int idx = int.Parse(Console.ReadLine());
                        //a b c d 
                        arr[idx] = arr[size - 1]; //вставляет последний элемент на место удаляемого (таким образом стираем удаляемый)
                        //a d c null
                        arr[size - 1] = null; //стираем последний элемент, потому что мы его перенесли в другое место 
                        //a d c null
                        size--; //уменьшаем счетчик кол-ва элементов
                        break;

                }
            }
        }
    }
}
