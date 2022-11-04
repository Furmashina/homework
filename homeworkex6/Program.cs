using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты думаешь что ввел число?");
            string a = Console.ReadLine();
            if (a == "1" || a == "2" || a == "3" || a == "4" || a == "5" || a == "6" || a == "7" || a == "8" || a == "9")
            {
                Console.WriteLine("Вы ввели число");
            }
            else
            {
                Console.WriteLine("Это не число");
            }
            
            
        }
    }
}
