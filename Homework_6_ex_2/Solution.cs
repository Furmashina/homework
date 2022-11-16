using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_ex_2
{
    //Создайте класс Solution с одним методов, который принимает в качестве параметров три значения: a,b,c.
    //Метод должен найти решение уравнения(значение x) и вернуть x в качестве результата с помощью return.
    internal class Solution
    {
        public int Disckriminant(int a, int b, int c)
        {
            int x = (c - b) / a;
            return x;
        }
        //Задача 2.2 Добавьте в класс Solution еще один метод поиска наибольшего числа из двух. Метод должен иметь два числовых параметра: a,b.
        //Метод сравнивает числа из параметров и возвращает наибольшее из них с помощью return.
        public int Max(int a, int b)
        {
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            else if (b > a)
            {
                max = b;
            }
            return max;
        }
        //Задача 2.3 Добавьте в класс Solution еще один метод.Метод принимает одно число через параметр и возвращает данное число, возведенное в квадрат.
        public int Square(int a)
        {
            int square = a * a;
            return square;
        }
        //Задача 2.4 Добавьте в класс Solution еще один метод.Метод принимает одно число через параметр и возвращает его факториал.
        public int Factorial(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                a = a * i;
            }
            return a;
        }
        //Задача 2.5 Добавьте в класс Solution метод решения квадратных уравнений вида a*x ^ 2 + b * x + c = 0.
        //Создайте метод с тремя параметрами: a,b,c.
        //Метод должен найти корни уравнения и вывести их на консоль.
        //Метод ничего не возвращает, только выводит на консоль.
        public double Square2(int a, int b, int c)
        {
            double d = b * b - 4 * a * c;
            if (d == 0)
            {
                double x1 = -b / (2 * a);
            }
            else if (d > 0)
            {
                double x1 = -b + Math.Sqrt(d) / (2 * a);
                double x2 = -b - Math.Sqrt(d) / (2 * a);
            }
            else
            {
                Console.WriteLine("Нет корней");
            }
            return d;
        }
    }
}
