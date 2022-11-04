using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4_ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2 Создать массив на 10 элементов, заполнить его числами в диапазоне от 0 до 100, вывести элементы массива в вместе с их индексами.
            //К примеру, есть массив { 1,8,4}, тогда программа должна вывести:
            //0: 1
            //1: 8
            //2: 4
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(0, 100);
                Console.WriteLine($"{i}: {arr[i]}");
            }
        }
    }
}
