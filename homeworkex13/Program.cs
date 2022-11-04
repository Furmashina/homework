using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество звездочек");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++) Console.WriteLine("*");
        }
    }
}
           