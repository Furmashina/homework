using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_8_ex_4
{
    internal class Accounts
    {
        //Создать класс BankAccount с полями

        //сумму на счету
        //номер счета(уникальное значение)
        //процент на остаток(годовой процент)
        //Создайте список счетов и заполните его 10 - ю счетами.Не забудьте, что номер счета при этом не должен повторяться.
        //Создайте меню:
        //1.Вывести все счета
        //2.Вывести сумму на счете по номеру(юзер вводит номер)
        //3.Сделать перевод.Юзер вводит номер счета-отправителя, номер счета-получателя и сумму перевода.Сделайте проверку, что баланса отправителя хватает для перевода
        //4.Найти счет с самым большим процентом на остаток(найти целый объект)
        //5.Найти счет, владелец которого заработает больше всех процентов, если будет держать деньги на нем целый год.Прибыль за год вычисляется по формуле сумма на счету*
        //процент на остаток / 100
        //6.Выход
        public int summ;
        public int number;
        public double percent;
        public Accounts(int summ, int number, double percent)
        {
            this.summ = summ;
            this.number = number;
            this.percent = percent;
        }
        public override string ToString()
        {
            return summ + " " + number + " " + percent;
        }
        public string PrintNumber()
        {
            return "Счёт" + number + "имеет сумму" + summ;
        }
    }
}
