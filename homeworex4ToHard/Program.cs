using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworex4ToHard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a");
            int a = int.Parse(Console.ReadLine());
            Console.Write("введите значение b");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите значение c");
            int c = int.Parse(Console.ReadLine());
            int d = b ^ 2 - 4 * a * c;
            int x1 = (-b + d ^ 2) / 2 * a;
            int x2 = (-b - d ^ 2) / 2 * a;
            if (d > 0)
            {
                Console.WriteLine(d , x1);
            }
            else if (d == 0)
            {
                Console.WriteLine(x2);
            }
            else
            {
                Console.WriteLine("Уравнение не имеет решения");
            }

        
        }
    }
}
