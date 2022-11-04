using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_4_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сгенерировать 10 случ чисел
            Random rnd = new Random();
            int count = 0;
            while (count < 10)
            {
                int val = rnd.Next(1, 10);
                Console.WriteLine(count+": "+val);
                count = count + 1;
            }

        }
    }
}
