using homework_6_ex_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_ex_6
{
    internal class Wallet
    {
        public double balance;
        public string type; //Тип валюты (рубли, доллары...)

        public Wallet(double balance, string type)
        {
            this.balance = balance;
            this.type = type;
        }

        public double Rub()
        {
            double rub;
            if (type.Equals("USD"))
            {
                rub = balance * 74;
                return rub;
            }
            else if (type.Equals("EUR"))
            {
                rub = balance * 95;
                return rub;
            }
            else
            {
                rub = balance;
                return rub;
            }
        }
    }
}
