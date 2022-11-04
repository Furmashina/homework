using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая будет выполнять арифметические операции (сложение, умножение, вычитание, деление).
            //Пользователь вводит знак действия(+, -, * или /), вводит два числа и программа выдает соответствующий результат.
            //Пример работы программы:
            //Введите действие:
            //+
            //Введите первое число:
            //2
            //Введите второе число:
            //            3
            //2 + 3 = 5
            
            int number1, number2;
            string action;
            Console.WriteLine("Enter the action +, -, /, *");
            action = Console.ReadLine();
            Console.Write("Enter to 1 number ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter to 2 number ");
            number2 = int.Parse(Console.ReadLine());
            switch (action)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);     //тут мои познания закончились. Мне выдает только текстом.
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    Console.WriteLine(number1 / number2);
                    break;
            }    
        }
    }
}
