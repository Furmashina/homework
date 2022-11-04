using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1 Создать массив на 10 элементов, заполнить его числами в диапазоне от 100 до 1000.
            //Пользователь вводит с консоли числа m и n,
            //вывести на консоль числа из массива, которые находятся в диапазоне от m до n.
            //К примеру, есть массив { 1,8,4}, m = 2, n = 10 тогда программа должна вывести:
            //8 4
            Console.WriteLine("Введите первое число");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(100, 1000);
                if (arr[i] > m && arr[i] < n)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            
        }
    }
}
