using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4_ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 4 Создать массив на 15 элементов, заполнить его числами в диапазоне от 0 до 20, вывести элементы массива в одну строку. 
            //Найти среднее арифметическое элементов массива

            int[] arr = new int[15];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0,20);
                Console.Write($"{arr[i]} ");
                sum = sum + arr[i];
            }
            Console.WriteLine("А где это говно то????");
            sum = sum / arr.Length;
            Console.WriteLine(sum);
        }
    }
}
