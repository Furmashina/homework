using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_ex_3
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
            string input = " ";   
            while (input != "5")
            {
                if (!NewGame)
                {
                    Console.WriteLine("0.Начать игру");
                    Console.WriteLine("Конец приключения. Сохранитесь...");
                }
                else
                {
                    Console.WriteLine("1.Приключение");
                    Console.WriteLine("2.Инвентарь");
                    Console.WriteLine("3.Статистика");
                    Console.WriteLine("4.Текущее задание");
                }
                input = Console.ReadLine();
                switch(input)
                {
                    case "0":
                            Console.WriteLine("Выбери свой путь");
                            Console.WriteLine("Правда?");
                            Console.WriteLine("или");
                            Console.WriteLine("Ложь?");
                            string choise = Console.ReadLine();
                            if (choise == "правда")
                            {
                                Console.WriteLine("Это путь приключения");
                                NewGame = true;
                            }
                            else if (choise == "ложь")
                            {
                                Console.WriteLine("Приключения никуда не денутся ;)");
                            }
                            break;
                    case "1":
                        Random rnd = new Random();
                        Console.WriteLine("Какая дорога вам уготована?");
                        int place = rnd.Next(1,3);
                        if (place == 1)
                        {
                            int HeroHp = 100;
                            int MobHP = 50;
                            Random rnd2 = new Random();
                            int dmgMob = rnd2.Next(1,10);
                            Random rnd3 = new Random();
                            int dmgHero = rnd3.Next(1, 10);
                            Console.WriteLine("Это путь битвы.");
                            Console.WriteLine("Вы идете по дороге и видите в далеке фигуру");
                            Console.WriteLine("Кабан 4го уровня набрасывается на вас как голодный я на пиво");
                            Console.WriteLine("Вы наносите по кабану - ", dmgHero);
                            Console.WriteLine(MobHP - dmgHero);
                            Console.WriteLine("Кабан атакует вас! Получено - ", dmgMob);
                            Console.WriteLine(HeroHp - dmgMob);
                            Console.WriteLine("Победила - Дружба");
                        }
                        else if (place == 2)
                        {
                            Console.WriteLine("Получите предмет!");
                        }
                        else if (place == 3)
                        {
                            Console.WriteLine("Проверка");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Bye-bye!");
                        break;
                }
            }
        }
    }
}
