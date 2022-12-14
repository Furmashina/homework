using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_8_ex_3
{
    internal class Fruit
    {
        //Создать класс Fruit(фрукт) с полями:
        //-название
        //- стоимость
        //- польза(по пятибальной шкале)(от 0 до 5 включительно)
        //Создать метод print - выводит все характеристики фрукта на консоль.
        public string name;
        public int price;
        public int useful;

        public Fruit(string name)
        {
            this.name = name;
        }

        public Fruit(string name, int price, int useful) : this(name)
        {
            this.price = price;
            this.useful = useful;
        }

        public void Print()
        {
            Console.WriteLine($"Фрукт - {name} - стоимость - {price}, полезность фрукта - {useful}");
        }
    }
}
