using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4_ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать массив на 5 элементов, заполнить его строками с консоли.Далее, после заполнения, считать с консоли одну строку и проверить, есть ли она в массиве. 
            //Программа должна вывести: Строка есть в массиве или Строки нет в массиве
            string[] arr = new string[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите информацию в консоль");
                arr[i] = Console.ReadLine();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            //arr = new string[] { "one", "two", "three", "four", "five" };
            Console.Write("Enter a line: ");
            string line = Console.ReadLine();
            bool isExist = false; //существует ли?
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == line)
                {
                    isExist = true;
                }
               
            }

            if (isExist)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
