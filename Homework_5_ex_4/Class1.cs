using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_ex_4
{
    internal class BankAccount
    {
        public int summScore;
        public int nameScore;
        public double percentYear;
        
        public BankAccount(int summ, int name, double percent)
        {
            this.summScore = summ;
            this.nameScore = name;
            this.percentYear = percent;
        }

        public void PrintAccount()
        {
            Console.WriteLine($"Сумма счета - {summScore}, Номер счета - {nameScore}, Годовой процент - {percentYear}");
        }
    }
}
