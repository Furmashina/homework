using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_8_ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 4 Выполнить старую задачу через List.Вы можете создавать свои конструкторы / методы и прочее:
            //Создайте список счетов и заполните его 10 - ю счетами.Не забудьте, что номер счета при этом не должен повторяться.
            //Создайте меню:
            //1.Вывести все счета
            //2.Вывести сумму на счете по номеру(юзер вводит номер)
            //3.Сделать перевод.Юзер вводит номер счета-отправителя, номер счета-получателя и сумму перевода.Сделайте проверку, что баланса отправителя хватает для перевода
            //4.Найти счет с самым большим процентом на остаток(найти целый объект)
            //5.Найти счет, владелец которого заработает больше всех процентов, если будет держать деньги на нем целый год.Прибыль за год вычисляется по формуле сумма на счету*
            //процент на остаток / 100
            //6.Выход
            List<Accounts> BankAccounts = new List<Accounts>();
            int input = 0;
            while (input != 6)
            {
                Console.WriteLine("0.Заполнить список");
                Console.WriteLine("1.Вывести все счета");
                Console.WriteLine("2.Вывести сумму на счете по номеру(юзер вводит номер)");
                Console.WriteLine("3.Сделать перевод.");
                Console.WriteLine("4.Найти счет с самым большим процентом на остаток(найти целый объект)");
                Console.WriteLine("5.Найти счет, владелец которого заработает больше всех процентов, если будет держать деньги на нем целый год.");
                Console.WriteLine("6.Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        bool approve = false;
                        Console.WriteLine("Введите номер счёта");
                        int bank_count = int.Parse(Console.ReadLine());
                        for (int i = 0; i < BankAccounts.Count; i++)
                        {
                            if (bank_count != BankAccounts[i].number)
                            {
                                approve = true;//можно попытаться через Екюалс сверить...
                            }
                        }
                        Console.WriteLine("Введите сумму счёта");
                        int bank_summ = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите процент на остаток");
                        double bank_percent = double.Parse(Console.ReadLine());
                        if (approve)
                        {
                            BankAccounts.Add(new Accounts(bank_count, bank_summ, bank_percent));
                        }
                        break;
                    case 1:
                        for (int i = 0; i < BankAccounts.Count; i++)
                        {
                            BankAccounts[i].ToString();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите номер счёта"); // можно написать метод вывода.
                        int numberAcconuts = int.Parse(Console.ReadLine());
                        Console.WriteLine($"у счета {BankAccounts[numberAcconuts].number} сумма {BankAccounts[numberAcconuts].summ}");
                        break;
                    case 3:
                        //3.Сделать перевод.Юзер вводит номер счета-отправителя, номер счета-получателя и сумму перевода.
                        //Сделайте проверку, что баланса отправителя хватает для перевода
                        bool approveCount = false;
                        Console.WriteLine("Ввелите индекс с которого перевести деньги");
                        int indexCount1 = int.Parse(Console.ReadLine());
                        int indexTrasfer1 = BankAccounts.IndexOf(indexCount1);
                        Console.WriteLine("Введите индекс, на который надо перевести деньги");
                        int indexCount2 = int.Parse(Console.ReadLine());
                        int indexTransfer2 = BankAccounts.IndexOf(indexCount2);
                        if (indexCount1 != -1 && indexCount2 != -1)
                        {
                            approveCount = true;
                        }
                        else
                        {
                            Console.WriteLine("Индекс не найден");
                        }
                        if (approveCount)
                        {
                            for (int i = 0; i < BankAccounts.Count; i++)
                            {
                                Console.WriteLine("Введите сумму для перевода");
                                int summTransfer = int.Parse(Console.ReadLine());
                                if (BankAccounts[i].summ < summTransfer)
                                {
                                    Console.WriteLine("Недостаточно средств");
                                }
                                else
                                {
                                    BankAccounts[indexCount1].summ -= summTransfer;
                                    BankAccounts[indexCount2].summ += summTransfer;
                                }
                            }
                        }
                        break;
                    case 4:
                        //4.Найти счет с самым большим процентом на остаток(найти целый объект)
                        double indexMax = 0;
                        int indexPercent = -1;
                        for (int i = 0; i < BankAccounts.Count; i++)
                        {
                            if (BankAccounts[i].percent > indexMax)
                            {
                                indexMax = BankAccounts[i].percent;
                                indexPercent = i;
                            }
                        }
                        Console.WriteLine($"Самый большой процент будет у счёта {BankAccounts[indexPercent].number} и его процент составляет {BankAccounts[indexPercent].percent} ");
                        break;
                    case 5:
                        //5.Найти счет, владелец которого заработает больше всех процентов, если будет держать деньги на нем целый год.Прибыль за год вычисляется по формуле сумма на счету*
                        //процент на остаток / 100
                        double maxDohod = 0;
                        int indexMaxDohod = -1;
                        for (int i = 0; i < BankAccounts.Count; i++)
                        {
                            if (BankAccounts[i].summ * BankAccounts[i].percent / 100 > indexMaxDohod)
                            {
                                maxDohod = BankAccounts[i].summ * BankAccounts[i].percent / 100;
                                indexMaxDohod = i;
                            }
                        }
                        Console.WriteLine($"максимальная прибыль за год будет у счёта - {BankAccounts[indexMaxDohod].number} с процентной ставкой - {BankAccounts[indexMaxDohod].percent}\n И будет составлять {maxDohod}");
                        break;
                }
            }
        }
    }
}
