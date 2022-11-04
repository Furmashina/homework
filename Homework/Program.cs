using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("Введите число");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Ахуеть");
            }
            else
            {
                Console.WriteLine("Пиздец");
            }
        }
    }
}
