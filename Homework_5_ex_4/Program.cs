using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Задача 5 Создать класс BankAccount с полями
//сумму на счету
//номер счета(уникальное значение)
//процент на остаток(годовой процент)
//Создайте массив счетов на 10 элементов и заполните его. Не забудьте, что номер счета при этом не должен повторяться.
//Создайте меню:
//1.Вывести все счета
//2.Вывести сумму на счете по номеру(юзер вводит номер)
//3.Сделать перевод.Юзер вводит номер счета-отправителя, номер счета-получателя и сумму перевода.Сделайте проверку, что баланса отправителя хватает для перевода
//4.Найти счет с самым большим процентом на остаток(найти целый объект)
//5.Найти счет, владелец которого заработает больше всех процентов, если будет держать деньги на нем целый год.Прибыль за год вычисляется по формуле сумма на счету* процент на остаток / 100
//6.Выход
            BankAccount[] score = new BankAccount[10];
            int input = 0;
            int index = 0;
            while (input != 6)
            {
                Console.WriteLine("0. Заполнить массив");
                Console.WriteLine("1. Вывести все счета");
                Console.WriteLine("2. Вывести сумму на счете по номеру");
                Console.WriteLine("3. Сделать перевод");
                Console.WriteLine("4. Найти счёт с самым большим процентом");
                Console.WriteLine("5. Найти счет, владелец которого заработает больше всех процентов в течении года");
                Console.WriteLine("6. Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        bool approveNumb = true;
                        bool approveSumm = true;
                        bool approvePercent = true;
                        Console.WriteLine("Введите сумму на счете");
                        int summScor = int.Parse(Console.ReadLine());
                        for (int i = 0; i < score.Length; i++)
                        {
                            if (summScor != 0)
                            {
                                approveSumm = false;
                            }
                        }
                        Console.WriteLine("Введите номер счета");
                        int numberScor = int.Parse(Console.ReadLine());
                        for (int i = 0; i < score.Length; i++)
                        {
                            if (score[i] != null && score[i].nameScore == numberScor)
                            {
                                approveNumb = false;
                            }
                        }
                        Console.WriteLine("Введите процент за год");
                        double percentScor = double.Parse(Console.ReadLine());
                        for (int i = 0; i < score.Length; i++)
                        {
                            if (percentScor != 0)
                            {
                                approvePercent = false;
                            }
                        }
                        if (approveNumb && approvePercent && approveSumm)
                        {
                            score[index++] = new BankAccount(summScor, numberScor, percentScor);
                        }
                        break;
                    case 1:
                        for (int i = 0; i < score.Length; i++)
                        {
                            score[i].PrintAccount();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите ваш счёт");
                        int scorename = int.Parse(Console.ReadLine());
                        for (int i = 0; i < score.Length; i++)
                        {
                            if (scorename == score[i].nameScore)
                            {
                                Console.WriteLine($"Сумма на счете {score[i].nameScore} = {score[i].summScore}$");
                            }
                        }
                        break;
                    case 3:
                        int scoreIndex1 = -1;
                        int scoreIndex2 = -1;
                        Console.WriteLine("Введите счёт, с которого нужно перевести деньги");
                        int score1Transfer = int.Parse(Console.ReadLine());
                        for (int i = 0; i < score.Length; i++)
                        {
                            if (score[i].nameScore != 0 && score1Transfer == score[i].nameScore)
                            {
                                scoreIndex1 = i;
                            }
                        }
                        Console.WriteLine("Введите счёт, на который нужно перевести деньги");
                        int score2Transfer = int.Parse(Console.ReadLine());
                        for (int i = 0; i < score.Length; i++)
                        {
                            if (score[i].nameScore != 0 && score2Transfer == score[i].nameScore)
                            {
                                scoreIndex2 = i;
                            }
                        }
                        if (score1Transfer == -1 || score2Transfer == -1)
                        {
                            Console.WriteLine("Счета не найдены");
                        }
                        else
                        {
                            Console.WriteLine("Введите сумму перевода");
                            int summTransfer = int.Parse(Console.ReadLine());
                            if (score[scoreIndex1].summScore < summTransfer)
                            {
                                Console.WriteLine("на счёте недостаточно денег");
                            }
                            else
                            {
                                score[scoreIndex1].summScore -= summTransfer;
                                score[scoreIndex2].summScore += summTransfer;
                            }
                        }
                        break;
                    case 4:
                        int max = 0;
                        Console.WriteLine("Найти счет с самым большим процентом на остаток");

                }
            }
        }
    }
}

