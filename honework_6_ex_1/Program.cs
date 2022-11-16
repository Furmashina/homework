
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace honework_6_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1 Создать класс Calculator.
            //Методы:
            //int sum(int a, int b) -принимает 2 числа через параметры и возвращает сумму чисел
            //int minus(int a, int b) -возвращает разницу чисел
            //mult - принимает 2 числа через параметры и возвращает произведение чисел
            //divide - принимает 2 числа через параметры и возвращает результат деления чисел
            //greater - принимает 2 числа через параметры и возвращает нибольшее из двух чисел или любое из них, если числа равны
            //lesser - принимает 2 числа через параметры и возвращает наименьшее из двух чисел или любое из них, если числа равны
            //abs - принимает 1 положительное или отрицательное число и возвращает его по модулю(со знаком плюс).Модуль это число со знаком плюс.Пример: модуль числа 5 равен 5,
            //модуль числа -5 равен 5.


            //В мейне создайте объект класса Calculator и меню:
            //1.Сложить(нужно считать два числа и вызвать метод sum)
            //2.Умножить(нужно считать два числа вызвать метод mult)
            //3.Делить(нужно считать два числа вызвать метод divide)
            //4.Вычесть(нужно считать два числа вызвать метод mult)
            //4.Наибольшее(нужно считать два числа вызвать метод greater)
            //5.Наименьшее(нужно считать два числа вызвать метод lesser)
            //6.Модуль(нужно считать одно число вызвать метод abs)
            //7.Выход
            //Calculator calc = new Calculator();//Для метода создаем новый класс
            //int result = calc.Sum(5, 20); //Для сохранения метода создаем переменную в которую записываем результат
            //Console.WriteLine(result); //Выводим результат
            //result = calc.Abs(4);//можем дальше использовать переменную для сохранения значений.
            //Console.WriteLine(result);
            Calculator clc = new Calculator();
            int input = 0;
            while (input != 8)
            {
                Console.WriteLine("1.Сложить");
                Console.WriteLine("2.Вычесть");
                Console.WriteLine("3.Делить");
                Console.WriteLine("4.Умножить");
                Console.WriteLine("5.Наибольшее");
                Console.WriteLine("6.Наименьшее");
                Console.WriteLine("7.Модуль");
                Console.WriteLine("8.Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Введите первое число");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        int b = int.Parse(Console.ReadLine());
                       
                        int result = clc.Sum(a, b);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        Console.WriteLine("Введите первое число");
                        int a1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        int b1 = int.Parse(Console.ReadLine());
                       
                        int res = clc.Minus(a1, b1);
                        Console.WriteLine(res);
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число");
                        int a2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        int b2 = int.Parse(Console.ReadLine());
                        
                        result = clc.Divite(a2, b2);
                        Console.WriteLine(result);
                        break;
                    case 4:
                        Console.WriteLine("Введите первое число");
                        int a3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        int b3 = int.Parse(Console.ReadLine());
                        
                        result = clc.Mult(a3, b3);
                        Console.WriteLine(result);
                        break;
                    case 5:
                        Console.WriteLine("Введите первое число");
                        int a4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        int b4 = int.Parse(Console.ReadLine());
                        
                        result = clc.Greater(a4, b4);
                        Console.WriteLine(result);
                        break;
                    case 6:
                        Console.WriteLine("Введите первое число");
                        int a5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        int b5 = int.Parse(Console.ReadLine());
                       
                        result = clc.Lesser(a5, b5);
                        Console.WriteLine(result);
                        break;
                    case 7:
                        Console.WriteLine("Введите число");
                        int a6 = int.Parse(Console.ReadLine());
                       
                        result = clc.Abs(a6);
                        Console.WriteLine(result);
                        break;
                    case 8:
                        Console.WriteLine("Вы вышли из программы");
                        break;
                }
            }
        }
    }

    class Calculator //Название в # пишутся с большой буквы
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }
        public int Divite(int a, int b)
        {
            return a / b;
        }
        public int Lesser(int a, int b)
        {
            int min = b;
            if (a < b)
            {
                min = a;
            }
            return min;
        }
        public int Greater(int a, int b)
        {
            int max = b;//Можно упростить поиск максимума, изначально указав значение. 
            if (a > b)//Если значение меняется - то проверка все равно пойдет. 
            {
                max = a;
            }
           
            return max;
        }
        public int Abs(int a)
        {
            int b = 0;
            if (a < 0)
            {
                b = a * -1; 
            }
            else
            {
                b = a;
            }
            return b;
        }
    }
}

