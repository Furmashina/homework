using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_ex_9
{
    internal class Calculator
    {
        //Создать класс Calculator.
        //Методы: метод поиска наибольшего числа, метод поиска наименьшего числа, метод поиска модуля числа
        //Методы поиска наибольшего и наименьшего числа принимает два параметра и возвращают результат.
        //Метод поиска модуля принимает одно число и возвращает результат.
        //Для каждого метода сделайте три перегрузки, которые будут позволяет работать со следующими форматами значений: целые числа, дробные числа, значения в типе string
        public int Max(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }

        public double Max(double a, double b)
        {
            if (a > b) return a;
            else return b;
        }

        public string Max(string a, string b)
        {
            if (int.Parse(a) > int.Parse(b)) return a;
            else return b;
        }

        public int Min(int a, int b)
        {
            if (a < b) return a;
            else return b;
        }

        public double Min(double a, double b)
        {
            if (a < b) return a;
            else return b;
        }

        public string Min(string a, string b)
        {
            if (int.Parse(a) < int.Parse(b)) return a;
            else return b;
        }

        public int Mod(int a)
        {
            if (a > 0) return a;
            else return Math.Abs(a);
        }

        public double Mod(double a)
        {
            if (a > 0) return a;
            else return Math.Abs(a);
        }

        public string Mod(string a)
        {
            int val = int.Parse(a);
            if (val < 0)
            {
                //val = val * -1;
                //или так:
                val = Math.Abs(val);
            }
            return val.ToString();


        }
    }
}
