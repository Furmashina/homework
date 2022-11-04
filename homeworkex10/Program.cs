using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое время суток");
            int time = int.Parse(Console.ReadLine());
            if (time >= 7 && time <= 11)
            {
                Console.WriteLine("morinng");
            }
            else if (time >= 12 && time <= 17)
            {
                Console.WriteLine("day");
            }
            else if (time >= 18 && time <= 21)
            {
                Console.WriteLine("evening");
            }
            else if (time >= 22 || time <= 6)
            {
                Console.WriteLine("night");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
