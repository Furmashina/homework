using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_ex_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сдеалть небольшую консольную игру.
            //Пете нужно собрать 4 изумруда.
            //Но для получения одного изумруда требуется сначала собрать 2 кристалла.
            //Напишите программу, позволяющую добывать кристаллы и обменивать их на изумруды до тех пор, пока Петя не соберет 4 изумруда.

            //Создайте консольное меню:
            //1.Собрать кристаллы(при выборе Петя получает один кристалл)
            //2.Конвертировать кристаллы в изумруды(когда Петя соберет два кристалла, он сможет конвертировать их в один изумруд)
            //3.Вывести текущий инвентарь Пети(выводится на консоль кол - во кристаллов и изумрудов, имеющееся у Пети)
            //4.Проверить, победил ли Петя

            //При выборе четвертого пункта программа должна проверить, собрал ли Петя 4 изумруда.
            //Если Петя их собрал, программа должна вывести "Петя победил!" и в идеале завершить работу программы. Если завершить работу программы так не получится,
            //сделайте завершение через дополнительный пункт меню, как мы это делали раньше.
            //Если Петя их не собрал, программа должна вывести "Пете не хватает n изумрудов!", где вместо n должно быть вставлено конкретное число.

            bool NewGame = false;
            string EndGame = " ";
            int kri = 0;
            int total_izum = 0;
            while (EndGame != "4" || EndGame != "5")
            {
                if (!NewGame)
                {
                    Console.WriteLine("Поможем Пете накопить изумруды?");
                    Console.WriteLine("0.Начать игру");
                    Console.WriteLine("5.Завершить игру");
                }
                else
                {
                    Console.WriteLine("1.Собрать кристаллы");
                  //  Console.WriteLine("2.Конвертировать кристаллы");
                    Console.WriteLine("2.Инвентарь");
                    Console.WriteLine("3.Статус");
                }
                
                if (kri >= 2)
                {
                    int izum = kri / 2; //3
                    if(izum * 2 < kri)
                    {
                        kri = kri - izum * 2;
                    }
                    else
                    {
                        kri = 0;
                    }
                   
                    total_izum = total_izum + izum;
                }
                EndGame = Console.ReadLine();
                switch (EndGame)
                {
                    case "0":
                        Console.WriteLine("Пете для победу нужно 4 изумруда. 1 изумруд = 2 кристалла");
                        Console.WriteLine("За каждую находку, Петя получает 1 кристалл");
                        Console.WriteLine("Для продолжения, введите - Кристалл");
                        string kristal = Console.ReadLine();
                        if (kristal.ToLower() == "кристалл")
                        {
                            Console.WriteLine("Приступим!");
                            NewGame = true;
                        }
                        break;
                    case "1":
                        Console.WriteLine("Петя идет по мрачному подземелью и видит перед собой загадочный предмет");//вот тут я как раз и наткнулся на проблему
                        kri = kri + 1;
                        Console.WriteLine("Петя находит " + 1 +" кристалл");
                       
                        break;
                    //case "2":
                    //    Console.WriteLine("Жлеаете конвертировать кристаллы в изумруды?");//2 кри = 1 изм
                    //    if(kri > 2)
                    //    {
                    //        int izumrud_count = kri / 2;

                    //    }
                        
                        //Console.WriteLine("Введите количество кристаллов");
                        //int conv = int.Parse(Console.ReadLine());
                        //if (conv == 2 && conv < 4)
                        //{
                        //    Console.WriteLine("Вы получили "+izum+" изумруд");
                        //}
                        //else if (conv == 4 && conv < 6)
                        //{
                        //    Console.WriteLine("Вы получили "+izum+" изумруда");
                        //}
                        //else if (conv == 6 && conv < 8)
                        //{
                        //    Console.WriteLine("Вы получили "+izum+" изумруда");//здесь ненужный пункт, я его потом исправлю. Не могу переключиться от предыдущего.
                        //}
                        //else if (conv == 8)
                        //{
                        //    Console.WriteLine("Вы можете получить " +izum+" изумруда и закончить игру");
                        //}
                        //else if (conv == 0 || conv == 1)
                        //{
                        //    Console.WriteLine("Вам нужно больше кристаллов для конвертации");
                        //}
                        //break;
                    case "2":
                        if (kri == 1)
                        {
                            Console.WriteLine("У Пети в инвенатре находится " + kri + " кристалл");
                        }
                        else if (kri == 2 || kri > 4)
                        {
                            Console.WriteLine("У Пети в инвенатре находится " + kri + " кристалла");
                        }
                        else if (kri == 5 || kri < 20)
                        {
                            Console.WriteLine("У Пети в инвенатре находится " + kri + " кристаллов");
                        }
                        Console.WriteLine();
                        if (total_izum == 1)
                        {
                            Console.WriteLine("У Пети в инвенатре находится " + total_izum + " изумруд");
                        }
                        else if (total_izum == 2 || total_izum < 5)
                        {
                            Console.WriteLine("У Пети в инвенатре находится " + total_izum + " изумруда");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Если вы накопили 4 изумруда, то Петя закончил игру");
                        Console.WriteLine("Введите количество изумрудов");
                        Console.ReadLine();
                        if (total_izum == 4)
                        {
                            Console.WriteLine("Поздравляем, вы собрали изумруды!");
                            Console.WriteLine("Петя победил!");
                            NewGame = false;
                        }
                        else if (total_izum == 1)
                        {
                            Console.WriteLine("Пете не хватает 3 изумрудов, продолжаем!");
                        }
                        else if (total_izum == 2)
                        {
                            Console.WriteLine("Пете не хватает 2х изумрудов, продолжаем!");
                        }
                        else if (total_izum == 3)
                        {
                            Console.WriteLine("Пете не хватает 1го изумруда, продолжаем!");
                        }
                        break;
                    case "4":
                        Console.WriteLine("До скорых встречь, путник!");
                        break;
                }
            }
        }
    }
}
