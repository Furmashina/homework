using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace homework_8_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3 Выполнить старую задачу через List.Вы можете создавать свои конструкторы / методы и прочее:
            //В мейне создать список фруктов Заполнить массив фруктами.
            //Создать консольное меню
            //1.Вывести все фрукты(всю информацию о каждом фрукте)
            //2.Вывести цену самого дорогого фрукта
            //3.Вывести название и цену фрукта под индексом
            //4.Вывести цену фрукта по названию
            //5.Найти сумму всех фруктов
            //6.Найти самый полезный фрукт(найти объект, который содержит данный фрукт и вывести его на консоль)
            //7.Выход
            List<Fruit> fruits = new List<Fruit>();
            int input = 0;
            while (input != 7)
            {
                Console.WriteLine("0.Ввести в список фрукты");
                Console.WriteLine("1.Вывести все фрукты(всю информацию о каждом фрукте)");
                Console.WriteLine("2.Вывести цену самого дорогого фрукта");
                Console.WriteLine("3.Вывести название и цену фрукта под индексом");
                Console.WriteLine("4.Вывести цену фрукта по названию");
                Console.WriteLine("5.Найти сумму всех фруктов");
                Console.WriteLine("6.Найти самый полезный фрукт(найти объект, который содержит данный фрукт и вывести его на консоль)");
                Console.WriteLine("7.Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        Console.WriteLine("Введите название фрукта");
                        string nameFruit = Console.ReadLine();
                        Console.WriteLine("Введите цену фрукта");
                        int priceFruit = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите полезность фрукта");
                        int usefulFruit = int.Parse(Console.ReadLine());
                        fruits.Add(new Fruit(nameFruit, priceFruit, usefulFruit));
                        break;
                    case 1:
                        for (int i = 0; i < fruits.Count; i++)
                        {
                            fruits[i].Print();
                        }
                        break;
                    case 2:
                        int max = 0;
                        int maxIndex = 0;
                        for (int i = 0; i < fruits.Count; i++)
                        {
                            if (fruits[i].price > max)
                            {
                                max = fruits[i].price;
                                maxIndex = i;
                            }
                        }
                        Console.WriteLine($"Самый дорогой фрукт - {fruits[maxIndex].name} и его стоимость - {max}");//Вернемся к этому
                        break;
                    case 3:
                        {
                            Console.WriteLine("Введите индекс фрукта");
                            int index = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Фрукт - {fruits[index].name} и цена - {fruits[index].price}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите название фрукта");
                            nameFruit = Console.ReadLine();
                            int index = fruits.IndexOf(new Fruit(nameFruit));
                            if (index != -1)//Я ща в дерби уйду
                            {
                                Console.WriteLine($"У фрукта {fruits[index].name}, цена - {fruits[index].price}");
                            }
                            else
                            {
                                Console.WriteLine("Я не нашев...");
                            }
                            break;
                        }
                    case 5:
                        int summ = 0;
                        for (int i = 0; i < fruits.Count; i++)
                        {
                            summ += fruits[i].price;
                        }
                        Console.WriteLine($"Сумма всех фруктов - {summ}");
                        break;
                    case 6:
                        //6.Найти самый полезный фрукт(найти объект, который содержит данный фрукт и вывести его на консоль)
                        Fruit fruit = fruits[0];
                        for (int i = 0; i < fruits.Count; i++)
                        {
                            if (fruits[i].useful > fruit.useful)
                            {
                                fruit = fruits[i];
                            }
                        }
                        Console.WriteLine($"Самый полезный фрукт - ");//?
                        fruit.Print();
                        break;
                }
            }
        }
    }
}
