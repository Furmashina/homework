using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваши балы");
            int a = int.Parse(Console.ReadLine());
            if (a>0 && a < 40)
            {
                Console.WriteLine("Ваша оценка 2");
            }
            else if (a >= 40 && a < 60)
            {
                Console.WriteLine("Ваша оценка 3");
            }
            else if (a >= 60 && a < 80)
            {
                Console.WriteLine("Ваша оценка 4");
            }
            else if (a >= 80 && a < 101)
            {
                Console.WriteLine("Ваша оценка 5");
            }
            else
            {
                Console.WriteLine("Ты дурак?");
            }
        }
    }
}
