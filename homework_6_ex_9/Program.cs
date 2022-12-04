using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3 Создать класс Calculator.
            //Методы: метод поиска наибольшего числа, метод поиска наименьшего числа, метод поиска модуля числа
            //Методы поиска наибольшего и наименьшего числа принимает два параметра и возвращают результат.
            //Метод поиска модуля принимает одно число и возвращает результат.
            //Для каждого метода сделайте три перегрузки, которые будут позволяет работать со следующими форматами значений: целые числа, дробные числа, значения в типе string
            Calculator calculator = new Calculator();
            string a = "2";
            int a2 = int.Parse(a);
            int b = 2;
            int val = calculator.Mod(a2);
        }
    }
}
