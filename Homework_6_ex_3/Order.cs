using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Homework_6_ex_3
{
    internal class Order
    {

        //Поля:
        //название блюда(в каждом заказе может быть только одно наименование блюда: кофе или мороженное, или чай и тд..)
        //цена бюда
        //количество наименования блюда в заказе(два чая или три чая или 2 кофе и тд)

        //Методы:
        //print - выводит информацию о заказе
        //getTotalPrice - возвращает итоговую цену заказа(цену блюда * количество в заказе)
        public string NameDish;
        public int PriceDish;
        public int QuanlityDish;

        public Order (string nameDish, int priceDish, int quanlityDish)
        {
            this.NameDish = nameDish;
            this.PriceDish = priceDish;
            this.QuanlityDish = quanlityDish;
        }   

        public void Print()
        {
            Console.WriteLine($"Название блюда - {NameDish}, цена блюда - {PriceDish}, Количество позиций в заказе - {QuanlityDish}");
        }

        public int PriceOrder()
        {
            return PriceDish * QuanlityDish;
        }
    }
}
