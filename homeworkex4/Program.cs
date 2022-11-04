using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая бы определяла количество решений у квадратного уравнения.

            //Квадратные уравнения это уравнения вида: a* x^2 + b * x + c
            //x ^ 2 означает x в квадрате.

            //Таким образом юзер будет вводить три числа: a,b,c.
            //Далее нужно вычислить дискриминант по формуле:
            //D = b ^ 2 - 4 * a * c
            //Если D > 0, выведите на консоль, что уравнение имеет два решения
            //Если D равен 0, выведите на консоль, что уравнение имеет одно решение
            //Если D < 0, выведите на консоль, что уравнение не имеет решения
            //int result = Math.Pow(2, 10);
            //double rs = Math.Sqrt(9);
            Console.Write("Введите значение a");
            int a = int.Parse(Console.ReadLine());
            Console.Write("введите значение b");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите значение c");
            int c = int.Parse(Console.ReadLine());
            int d = b * b  - 4 * a * c;// Почему тут надо 0 писать? из-за того, что у нас в блоке прописаны формулы уже?*/;
            double x1, x2;
            if (d == 0)
            {
                Console.WriteLine("У уравнения есть одно решение");
                x1 = -b / (2 * a);
                Console.WriteLine(x1);
            }
            else if (d > 0)
            {
                Console.WriteLine("Уравнение имеет два решения");
                x1 = -b + Math.Sqrt(d) / (2 * a);
                x2 = -b - Math.Sqrt(d) / (2 * a);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else
            {
                Console.WriteLine("Нет корней");
            }
        }
    }
}
