using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_ex_5
{
    internal class Passport
    {
        //int серия
        //int номер
        //string имя
        //string фамилия
        //string отчество
        //int возраст
        public int Ser;
        public int Number;
        public string Name;
        public string SecondName;
        public int Age;

        public Passport(int ser, int number, string name, string secondName, int age)
        {
            this.Ser = ser;
            this.Number = number;
            this.Name = name;
            this.SecondName = secondName;
            this.Age = age;
        }
    }
}
