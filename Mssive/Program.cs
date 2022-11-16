using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mssive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //Создать массив на 10 элементов, заполнить его числами в диапазоне от 100 до 1000.Пользователь вводит с консоли числа m и n, 
            //вывести на консоль числа из массива, которые находятся в диапазоне от m до n.
            //К примеру, есть массив { 1,8,4}, m = 2, n = 10 тогда программа должна вывести: 8 4
            //int[] arr = new int[10];
            //Random random = new Random();
            //Console.WriteLine("Введите первое число");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //int b = int.Parse(Console.ReadLine());
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(100,1000);
            //    if (a < arr[i] && b > arr[i])
            //    {
            //        Console.Write(arr[i] + " ");
            //    }
            //}

            //Задача 2
            //Создать массив на 10 элементов, заполнить его числами в диапазоне от 0 до 100, вывести элементы массива в вместе с их индексами.
            //К примеру, есть массив { 1,8,4}, тогда программа должна вывести:
            //0: 1
            //1: 8
            //2: 4
            //int[] arr = new int[10];
            //Random rnd = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(0, 100);
            //    Console.WriteLine($"{i} ; {arr[i]}");
            //}

            //Задача 3
            //Создать массив на 5 элементов, заполнить его числами в диапазоне от -10 до 100, вывести элементы массива в одну строку. 
            //Найти минимальный, максимальный элементы одномерного массива.
            //int[] arr = new int[5];
            //Random rnd = new Random();
            //int min = 100;
            //int max = -10;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(-10, 100);
            //    Console.Write($"{arr[i]} ");
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"максимальное - {max}, минимальное - {min}");

            //Задача 4
            //Создать массив на 15 элементов, заполнить его числами в диапазоне от 0 до 20, вывести элементы массива в одну строку. 
            //Найти среднее арифметическое элементов массива
            //int[] arr = new int[15];
            //Random rnd = new Random();
            //int sum = 0;
            //int val = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(0, 20);
            //    Console.Write($"{arr[i]} ");
            //    sum = sum + arr[i];
            //    val = sum / 15;
            //}
            //Console.WriteLine($"Среднее арифметическое = {val}");

            //Задача 5
            //Создать массив на 5 элементов, заполнить его строками с консоли.
            //Далее, после заполнения, считать с консоли одну строку и проверить, есть ли она в массиве. 
            //Программа должна вывести: Строка есть в массиве или Строки нет в массиве
            //string[] arr = new string[5];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Введите 5 строк");
            //    arr[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Запускаем проверку на строки");
            //Console.WriteLine("Введите строку на проверку");
            //bool approve = false;
            //string str = Console.ReadLine();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == str)
            //    {
            //        approve = true;
            //    }
            //}
            //if (approve)
            //{
            //    Console.WriteLine("Есть в массиве");
            //}
            //else
            //{
            //    Console.WriteLine("Нет в массиве");
            //}

            //Задача 6
            //Сделать список покупок на 5 элементов в виде массива.
            //Создать консольное меню:
            //1.Добавить покупку(юзер вводит название покупки.Новую покупку можно добавить только, если ее еще нет в списке)
            //2.Вывести список покупок(все элементы, кроме null)
            //3.Вывести на консоль количество добавленных покупок(то есть результатом должно быть одно число - кол - во не null покупок)
            //4.Удалить покупку(юзер вводит индекс и нужно приравнять значение под индексом к null)
            //5.Выход
            //string[] buy = new string[5];
            //bool approve = true;
            //int index = 0;
            //int input = 0;
            //while (input != 5)
            //{
            //    Console.WriteLine("1. Добавить покупку");
            //    Console.WriteLine("2. вывести список покупок");
            //    Console.WriteLine("3. вывести кол-во покупок");
            //    Console.WriteLine("4. Удалить покупку");
            //    Console.WriteLine("5. выход");
            //    input = int.Parse(Console.ReadLine());
            //    switch (input)
            //    {
            //        case 1:
            //            Console.WriteLine("Напишите чо купить");
            //            string buy_plan = Console.ReadLine();
            //            for (int i = 0; i < buy.Length; i++)
            //            {
            //                if (buy_plan == buy[i])
            //                {
            //                    approve = false;
            //                }
            //            }
            //            if (approve)
            //            {
            //                buy[index] = buy_plan;
            //                index++;
            //                Console.WriteLine("Покупка добавлена");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Покупка уже добавлена");
            //            }
            //            break;
            //            case 2:
            //            for (int i = 0; i < buy.Length; i++)
            //            {
            //                if (buy[i] != null)
            //                {
            //                    Console.WriteLine(buy[i]);
            //                }
            //            }
            //            break;
            //        case 3:
            //            Console.WriteLine(index);
            //            break;
            //        case 4:
            //            Console.WriteLine("введите индекс удаляемого товара");
            //            int idx = int.Parse(Console.ReadLine());
            //            buy[idx] = buy[index - 1];
            //            buy[index - 1] = null;
            //            index--;
            //            break;
            //}
            //}

            //Задача 8
            //Создать массив, хранящий паспортные данные пользователя.Допустим паспорт содержит данные: серия, номер и имя.
            //Необходимо создать три массива, которые будут хранить данные паспорта. Данные в массивах должны храниться таким образом, 
            //чтобы данные одного паспорта хранились под одинаковым индексом во всех массивах.
            //В мейне создать консольное меню:
            //1.Добавить паспорт
            //2.Вывести все паспорта
            //3.Удалить паспорт
            //4.Проверить паспорт на существование
            //5.Выход
            int[] ser = new int[3];
            int[] numb = new int[3];
            string[] name = new string[3];
            int index = 0;
            
            int input = 0;
            while (input != 5)
            {
                Console.WriteLine("1. Добавить паспорт");
                Console.WriteLine("2. Вывести все паспорта");
                Console.WriteLine("3. Удалить паспорт");
                Console.WriteLine("4. Проверить паспорт на существование");
                Console.WriteLine("5. Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        bool seraiApprove = true;
                        bool numberApprove = true;
                        Console.WriteLine("Введите серияю паспорта");
                        int seria = int.Parse(Console.ReadLine());
                        for (int i = 0; i < ser.Length; i++)
                        {
                            if (seria == ser[i])
                            {
                                seraiApprove = false;
                            }
                        }
                        Console.WriteLine("Введите номер паспорта");
                        int nomer = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numb.Length; i++)
                        {
                            if (nomer == numb[i])
                            {
                                numberApprove = false;
                            }
                        }
                        Console.WriteLine("Введите имя паспорта");
                        string imya = Console.ReadLine();
                        if (seraiApprove && numberApprove)
                        {
                            ser[index] = seria;
                            numb[index] = nomer;
                            name[index] = imya;
                            index++;
                            Console.WriteLine("Паспорт добавлен");
                        }
                        else
                        {
                            Console.WriteLine("Паспорт не добавлен");
                        }
                        break;
                    case 2:
                        //Все три массива имеют одинаковую длину, поэтому не важно, по какому из них запускать цикл
                        for (int i = 0; i < ser.Length; i++)
                        {
                            Console.WriteLine(ser[i]+" " + numb[i]+" "+ name[i]);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("напишите индекс: ");
                            int idx = int.Parse(Console.ReadLine());
                            ser[idx] = ser[index - 1];
                            numb[idx] = numb[index - 1];
                            name[idx] = name[index - 1];
                            ser[idx] = 0;
                            numb[idx] = 0;
                            name[idx] = null;
                            index--;
                            break;
                        }
                    case 4:
                        {
                            //для проверки наличия паспорта важно не только проверить, что серия, номер, имя существут в массивах, нужно еще проверить, что они находястя под одним индексом
                            int idx = -1; //начальное значение -1 означает, что это не существующий индекс
                            Console.WriteLine("Проверим паспорт на существование");
                            Console.WriteLine("Введите серию паспорта");
                            int seria1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите номер паспорта");
                            int nomer1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите имя паспорта");
                            string name1 = Console.ReadLine();
                            for (int i = 0; i < ser.Length; i++)
                            {
                                if (seria1 == ser[i])
                                {
                                    idx = i;
                                }
                            }
                            //проверяем, что нашли индекс серии
                            if (idx == -1)
                            {
                                Console.WriteLine("Паспорт не существует");
                            }
                            else
                            {
                                //проверяем ,что номер и имя юзера совпадают с номером и именем под этим индексом
                                if (nomer1 == numb[idx] && name1 == name[idx])
                                {
                                    Console.WriteLine("Паспорт существует");
                                }
                                else
                                {
                                    Console.WriteLine("Паспорт не существует");
                                }
                            }


                            break;
                        }
                    case 5:
                        Console.WriteLine("Вы вышли из программы");
                        break;
                }
            }
        }
    }
}
