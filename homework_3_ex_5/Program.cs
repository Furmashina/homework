using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3_ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 5 Пользователь вводит с консоли слово, разделитель и число n, нужно вывести на консоль слово через разделитель n раз.
            //Пример 1
            //Введите слово
            //Hello
            //Введите разделитель
            //X
            //Введите число
            //3
            //HelloXHelloXHello

            //Пример 2
            //Введите слово
            //Hello
            //Введите разделитель
            //And
            //Введите число
            //2
            //HelloAndHello

            //Пример 3
            //Введите слово
            //Hello
            //Введите разделитель
            //X
            //Введите число
            //1
            //Hello
            Console.WriteLine("Слово");
            string slovo = Console.ReadLine();
            Console.WriteLine("Разделитель");
            string razdelitel = Console.ReadLine();
            Console.WriteLine("Число");
            int chislo = int.Parse(Console.ReadLine());
           
         
            for (int i = 1; i <= chislo - 1; i++)
            {
                    Console.Write($"{slovo}{razdelitel}");
            }
            Console.WriteLine(slovo);
            
        }
    }
}
