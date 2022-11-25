using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2 Есть класс Wallet(бумажник), содержащий два поля: сумма в бумажнике и валюту, в которой находится эта сумма.
            //По заданию валюта может быть только трех видов: RUB, USD, EUR.
            //Вам не нужно беспокоиться о других валютах.
            //В коде ниже представлен уже написанный класс и создание трех объектов в мейне.
            //Ваша задача оптимизировать в код:
            //все, что можно убрать в конструктор нужно убрать конструктор,
            //все, что можно убрать в метод, нужно убрать в метод.
            //Подсказка, вам нужно создать один конструктор и один метод, хотя для решения нет определенных рамок,
            //главное, чтобы оно обеспечивало уменьшение кода в мейне, гарантировало отсутствие дублированного кода.
            //После изменений добавьте проверку для поля balance, чтобы в него нельзя было присвоить отрицательное значение.
            Wallet wallet = new Wallet(int.Parse(Console.ReadLine()), Console.ReadLine());
            Console.WriteLine("Напишите валюту счёта");
            string typeWallet = Console.ReadLine();
            if (typeWallet == wallet.type)
            {
                Console.WriteLine($"В бумажнике находится {wallet.Rub()}");
            }
        }
    }
}
