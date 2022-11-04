using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3_ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Задача 7 У первокласника пети 100 рублей.Мороженое стоит 15 рублей.Петя решил наесться досыта мороженого, для этого он покупал по одному мороженому
            //            и съедал его до тех пор, пока ему хватало денег. Как пете узнать, сколько денег останется у него в конце концов? учтите, что петя делить еще не умеет,
            //            а умеет только вычитать и складывать.сколько мороженых он может съесть?

            //Пример
            //Мороженное 1 15 руб, остаток: 85 руб
            //Мороженное 2 15 руб, остаток: 70 руб
            //Мороженное 3 15 руб, остаток: 55 руб
            //Мороженное 4 15 руб, остаток: 40 руб
            //Мороженное 5 15 руб, остаток: 25 руб
            //Мороженное 6 15 руб, остаток: 10 руб
            //Петя съел 6 штук, у него осталось 10 руб.
            int rub = 200;
            int stoimost = 20;
            int morozhenoe = 0;
            for (morozhenoe = 1; rub-stoimost>0; morozhenoe++)
            {
                rub = rub - stoimost;
                Console.WriteLine($"Мороженое {morozhenoe} {stoimost} руб, остаток = {rub}");
                
            }
            
            Console.WriteLine($"Петя съел {morozhenoe-1} штук, у него осталось {rub} рублей");
            
        }
    }
}
