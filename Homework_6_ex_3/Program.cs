using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3 Создать класс Order(Заказ).
            //В мейне создать массив на 10 элементов, заполнить его заказами и консольное меню:
            //1.вывести все заказы на консоль(выводится название, цена, количество, общая стоимость)
            //2.вывести самый дорогой заказ(исходя из total price)
            //3.вывести самый дешевый заказ(исходя из total price)
            //4.вывести все заказы, итоговая цена которых не более 1000(исходя из total price)
            //5.Вывести стоимость заказа по его названию(выводить total price.если заказов в одним названием несколько, вывести все найденные заказы)
            //6.Выход.
            Order[] orders = new Order[10];
            int index = 0;
            int input = 0;
            while (input != 6)
            {
                Console.WriteLine("0.добавить заказ");
                Console.WriteLine("1.вывести все заказы на консоль");
                Console.WriteLine("2.вывести самый дорогой заказ");
                Console.WriteLine("3.вывести самый дешевый заказ");
                Console.WriteLine("4.вывести все заказы, итоговая цена которых не более 1000");
                Console.WriteLine("5.вывести стоимость заказа по его названию");
                Console.WriteLine("6.выход.");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        Console.WriteLine("Введите название блюда");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите цену блюда");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите количество");
                        int quanlity = int.Parse(Console.ReadLine());
                        orders[index++] = new Order(name, price, quanlity);
                        break;
                    case 1:
                        for (int i = 0; i < orders.Length; i++)
                        {
                            if (orders[i] != null) //Всегда надо проверять данные по заполненному массиву, и если там есть информация, то выводить её.
                            {
                                orders[i].Print();
                            }
                        }
                        break;
                    case 2:
                        int maxTotalPrice = orders[0].PriceOrder();
                        int maxtotalPriceIndex = 0;
                        for (int i = 0; i < orders.Length; i++)
                        {
                            if (orders[i] != null && orders[i].PriceOrder() > maxTotalPrice)
                            {
                                maxTotalPrice = orders[i].PriceOrder();
                                maxtotalPriceIndex = i;
                            }
                        }
                        Console.WriteLine($"Самый дорогой заказ: \n {orders[maxtotalPriceIndex].NameDish}, \n имеет цену - {orders[maxtotalPriceIndex].PriceDish} \n количество в заказе равно - {orders[maxtotalPriceIndex].QuanlityDish}");
                        break;
                    case 3:
                        int minTotalPrice = orders[0].PriceOrder();
                        int mintotalPriceIndex = 10000;
                        for (int i = 0; i < orders.Length; i++)
                        {
                            if (orders[i] != null && orders[i].PriceOrder() < minTotalPrice)
                            {
                                minTotalPrice = orders[i].PriceOrder();
                                mintotalPriceIndex = i;
                            }
                        }
                        Console.WriteLine($"Самый дешевый заказ: \n {orders[mintotalPriceIndex].NameDish}, \n имеет цену - {orders[mintotalPriceIndex].PriceDish} \n количество в заказе равно - {orders[mintotalPriceIndex].QuanlityDish}");
                        break;
                    case 4:
                        for (int i = 0; i < orders.Length; i++)
                        {
                            if (orders[i] != null && orders[i].PriceOrder() < 1000)
                            {
                                orders[i].Print();
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        int indexNameDish = 0;
                        bool approve = false;
                        Console.WriteLine("Введите название блюда");
                        string nameDish1 = Console.ReadLine();
                        for (int i = 0; i < orders.Length; i++)
                        {
                        }
                        if (approve)
                        {
                            Console.WriteLine($"Блюдо {orders[indexNameDish].NameDish} стоит - {orders[indexNameDish].PriceOrder()}");
                        }
                        else
                        {
                            Console.WriteLine("Данного блюда не существует");
                        }
                        break;
                }
            
            }
        }
    }
}
