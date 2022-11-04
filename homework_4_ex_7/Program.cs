using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace homework_4_ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 7 Создать игру в угадайку: программа загадывает число от 1 до 5, юзер вводит с консоли свой вариант.
            //Если юзер угадал, ему засчитывается одно очко.
            //Для запуска игры, юзер должен зарегистрироваться и войти в свой аккаунт. 
            //Количество очков юзера должно сохраняться в аккаунте.
            //Создайте консольное меню:
            //1.Регистрация
            //2.Вход
            //3.Выход
            //Если юзер вошел в свой аккаунт(пункт 2), у него открывается подменю:
            //1.Сыграть
            //2.Выйти в главное меню
            int[] arrLog = new int[5];
            int[] arrPass = new int[5];
            int[] arrPlay = new int[5];
            int[] arrPoint = new int[5];
            Random rnd = new Random();
            int input = 0;
           
            int index = 0;
            int authorise = -1;
            Console.WriteLine("Сыграем в игру?");
            while (input != 5)
            {
                Console.WriteLine("1.Регистрация");
                Console.WriteLine("2.Вход");
                Console.WriteLine("3.Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите логин");
                            int log = int.Parse(Console.ReadLine());
                   
                            bool isExist = false;
                            for (int i = 0; i < arrLog.Length; i++)
                            {
                                if (log == arrLog[i])
                                {
                                    isExist = true;
                                }
                            }
                            if (!isExist)
                            {
                                Console.WriteLine("Введите пароль");
                                int pass = int.Parse(Console.ReadLine());
                                arrLog[index] = log;
                                arrPass[index] = pass;
                                index++;
                            }
                            else
                            {
                                Console.WriteLine("Данный игрок уже существует");
                            }
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine("Введите логин");
                            int log = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите пароль");
                            int pass = int.Parse(Console.ReadLine());
                            bool isExist = false;
                            for (int i = 0; i < arrLog.Length; i++)
                            {
                                if (log == arrLog[i] && pass == arrPass[i])
                                {
                                    isExist = true;
                                    authorise = i;
                                }
                            }
                            if (isExist)
                            {
                                int input2 = 0;
                                while (input2 != 3)
                                {
                                    Console.WriteLine("1.Сыграть");
                                    Console.WriteLine("2. Вывести кол-во очков");
                                    Console.WriteLine("3.Выйти в главное меню");
                                    input2 = int.Parse(Console.ReadLine());
                                    switch (input2)
                                    {
                                        case 1:
                                            Console.WriteLine("Играем в угадайку. Я загадываю тебе число от 1 до 5, а ты должен угадать какое.");
                                            Console.WriteLine("За каждый правильный ответ тебе будет начисляться 1 очко.");
                                            Console.WriteLine("Для победы нужно набрать 5 очков (да, у меня бзик на число 5!!!)");
                                            Console.WriteLine("Поехали!");
                                            int point = rnd.Next(1, 5);
                                            Console.WriteLine($"Какое число я загадал? {point}");
                                            int PointBooster = int.Parse(Console.ReadLine());
                                            if (PointBooster == point)
                                            {
                                                Console.WriteLine("Молодец, ты угадал! +1 очко");
                                                arrPoint[authorise]++;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ты не угадал. Повторим?");
                                            }
                                            break;
                                        case 2:
                                            Console.WriteLine("Ваш счет: "+arrPoint[authorise]);
                                            break;
                                        case 3:
                                            Console.WriteLine("Вы вернулись в главное меню");
                                            break;
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("вы вышли из программы. Пока!");
                        input = 5;
                        break;
                }
            }
        }
    }
}
