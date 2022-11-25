using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2
            //Часть 2.1 Сделать программу по вычислению уравнения вида a* x+b = c.

            //Создайте класс Solution с одним методов, который принимает в качестве параметров три значения: a,b,c.
            //Метод должен найти решение уравнения(значение x) и вернуть x в качестве результата с помощью return.

            //В мейне создайте считайте с консоли три числа и передайте их в метод.Выведите решение уравнения на консоль.Проверьте, что метод дает корректный ответ.

            //Задача 2.2 Добавьте в класс Solution еще один метод поиска наибольшего числа из двух. Метод должен иметь два числовых параметра: a,b.
            //Метод сравнивает числа из параметров и возвращает наибольшее из них с помощью return.

            //В мейне проверьте работу метода

            //Задача 2.3 Добавьте в класс Solution еще один метод.Метод принимает одно число через параметр и возвращает данное число, возведенное в квадрат.
            //В мейне проверьте работу метода


            //Задача 2.4 Добавьте в класс Solution еще один метод.Метод принимает одно число через параметр и возвращает его факториал.
            //В мейне проверьте работу метода

            //Задача 2.5 Добавьте в класс Solution метод решения квадратных уравнений вида a*x ^ 2 + b * x + c = 0.
            //Создайте метод с тремя параметрами: a,b,c.
            //Метод должен найти корни уравнения и вывести их на консоль.
            //Метод ничего не возвращает, только выводит на консоль.

            //В мейне проверьте работу методов.
            Solution solution = new Solution();
            //int result = solution.Disckriminant(2, 10, 4);
            //Console.WriteLine(result);
            //int resultMax = solution.Max(2, 1);
            //Console.WriteLine(resultMax);
            //int result = solution.Square(5);
            //Console.WriteLine(result);
            //int result = solution.Factorial(5);
            //Console.WriteLine(result);
            double[] arr = solution.Square2(4, 1, 3);
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
