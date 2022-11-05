using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5_ex_2
{
    internal class Program
    {
        static void Main(string[] args)
//Задача 3 Создать класс Fruit(фрукт) с полями:
//- название
//- стоимость
//- польза(по пятибальной шкале) (от 0 до 5 включительно)

//Создать метод print - выводит все характеристики фрукта на консоль.
//В мейне создать массив фруктов на 5 элементов.Заполнить массив фруктами.
//Создать консольное меню
//1. Вывести все фрукты (всю информацию о каждом фрукте)
//2. Вывести цену самого дорогого фрукта
//3. Вывести название и цену фрукта под индексом
//4. Вывести цену фрукта по названию
//5. Найти сумму всех фруктов
//6. Найти самый полезный фрукт(найти объект, который содержит данный фрукт и вывести его на консоль)
//7. Выход

        {
            Fruit apple = new Fruit();
            apple.name = "Яблоко";
            apple.buysell = 10;
            apple.positive = 5;

            Fruit orange = new Fruit();
            orange.name = "Апельсин";
            orange.buysell = 15;
            orange.positive = 3;

            Fruit banana = new Fruit();
            banana.name = "Бананза";
            banana.buysell = 20;
            banana.positive = 2;

            Fruit arbuz = new Fruit();
            arbuz.name = "Арбуз";
            arbuz.buysell = 100;
            arbuz.positive = 4;

            Fruit beer = new Fruit();
            beer.name = "Очаково";
            beer.buysell = 125;
            beer.positive = 5;

            Fruit[] arr = new Fruit[5];
            arr[0] = apple;
            arr[1] = orange;
            arr[2] = banana;
            arr[3] = arbuz;
            arr[4] = beer;
            int input = 0;
            while (input != 7)
            {
                Console.WriteLine("1. Вывести все фрукты");
                Console.WriteLine("2. Вывести цену самого дорогого фрукта");
                Console.WriteLine("3. Вывести название и цену фрукта под индексом");
                Console.WriteLine("4. Вывести цену фрукта по названию");
                Console.WriteLine("5. Найти сумму всех фруктов");
                Console.WriteLine("6. найти самый полезный фрукт");
                Console.WriteLine("7. выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] != null)
                            {
                                Console.WriteLine(arr[i].name);
                            }
                        }
                        break;
                     case 2:
                        {
                            int max = 0;
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i].buysell > max)
                                {
                                    max = arr[i].buysell;
                                }
                            }
                            Console.WriteLine(max);
                            break;
                        }
                    case 3:
                        Console.WriteLine("Введите индекс фрукта"); //При вводе индекса программа автоматически считывает данные из массива. 
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine(arr[index].name+" " + arr[index].buysell); //arr[0] arr[1] 
                        break;
                    case 4:
                        Console.WriteLine("Введите названмие фрукта"); //Чтобы прокрутить цикл, нужно уточнить после массива к чему мы обращаемся. 
                        string name = Console.ReadLine();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (name == arr[i].name)
                            {
                                Console.WriteLine(arr[i].buysell);//автоматически подтянет информацию по имени. если будет 2 одинаковых названия, то будет несколько информаций.
                            }
                        }
                        break;
                    case 5:
                        int sum = 0;
                        for (int i = 0; i < arr.Length; i++)
                        {
                            int val = arr[i].buysell;
                            sum += val;
                        }
                        Console.WriteLine(sum);

                        break;
                    case 6:
                        {
                            int max = 0;
                            int maxIndex = 0;
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i].positive > max)
                                {
                                    max = arr[i].positive;
                                    max = i;
                                }
                            }
                            Console.WriteLine("Самый пользеный фрукт: " + arr[maxIndex].name);//сохранили значение под индексом, чтобы потом его использовать. 
                            Console.WriteLine("Его польза: " + arr[maxIndex].positive);
                            break;
                        }
                    case 7:
                        break;
                }
            }
        }
    }
}
class Fruit
{
    public string name;
    public int buysell;
    public int positive;

    public void FruitPrint()
    {
        Console.WriteLine(name + " " + buysell + " " + positive);
    }
}
