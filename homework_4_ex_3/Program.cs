using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3 Создать массив на 5 элементов, заполнить его числами в диапазоне от -10 до 100, вывести элементы массива в одну строку. 
            //Найти минимальный, максимальный элементы одномерного массива.
            int[] arr = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 100);
                Console.Write(arr[i]);
            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("max: " + max);
            Console.WriteLine("min: " + min);
        }
    }
}
