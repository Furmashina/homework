using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masssive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop[] lp = new Laptop[5];
            Random rnd = new Random();
            int index = 0;
            for (int i = 0; i < lp.Length; i++)
            {
                lp[index] = new Laptop(rnd.Next(1, 5), rnd.Next(2, 4), rnd.Next(5, 10));
                index++;
            }
        }
    }
}
