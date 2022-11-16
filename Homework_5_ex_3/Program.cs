using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //В мейне создайте массив на 5 объектов класса Character, заполните его объектами класса Character.
            //После заполнения выведите на консоль информацию о всех персонажах(их название, класс, урон).
            //Далее выполните задачи:
            //1.Юзер вводит с консоли требуемый класс персонажа, программа должна вывести из массива всех персонажей, чей класс совпадает с введенным с консоли.
            //2.Юзер вводит с консоли урон, которым должен обладать персонаж.Выведите на консоль всех персонажей, чей урон больше или равен введенному с консоли
            //3.Юзер вводит класс и урон. Выведите всех персонажей, чей класс совпадает с введенным и чей урон больше или равен введенному.
            Character warrior = new Character();
            warrior.nameCharacter = "Гаррош";
            warrior.specCharacter = "Воин";
            warrior.damageCharacter = 50;
            Character priest = new Character();
            priest.nameCharacter = "Андуин";
            priest.specCharacter = "Жрец";
            priest.damageCharacter = 15;
            Character rouge = new Character();
            rouge.nameCharacter = "Шоу";
            rouge.specCharacter = "Убийца";
            rouge.damageCharacter = 40;
            Character archer = new Character();
            archer.nameCharacter = "Сильвана";
            archer.specCharacter = "Лучник";
            archer.damageCharacter = 35;
            Character deathKnight = new Character();
            deathKnight.nameCharacter = "Болвар";
            deathKnight.specCharacter = "Рыцарь смерти";
            deathKnight.damageCharacter = 55;

            Character[] pers = new Character[5];
            pers[0] = warrior;
            pers[1] = priest;
            pers[2] = rouge;
            pers[3] = archer;
            pers[4] = deathKnight;

            int input = 0;
            while (input != 4)
            {
                Console.WriteLine("1. Введите класс персонажа для информации о нем");
                Console.WriteLine("2. Поиск по урону для подходящего класса");
                Console.WriteLine("3. Поиск по урону и клссу для подходящего класса");
                Console.WriteLine("4. Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Введите название класса для получения информации");
                        string inputSpec = Console.ReadLine();
                        for (int i = 0; i < pers.Length; i++)
                        {
                            if (inputSpec == pers[i].specCharacter)
                            {
                                Console.WriteLine($" Имя - {pers[i].nameCharacter}\n Специализация - {pers[i].specCharacter}\n Урон - {pers[i].damageCharacter}");
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Введите предпочитаемый урон для поиска подходящего класса");
                            int damageSpec = int.Parse(Console.ReadLine());
                            for (int i = 0; i < pers.Length; i++)
                            {
                                if (damageSpec > pers[i].damageCharacter || damageSpec == pers[i].damageCharacter)
                                {
                                    Console.WriteLine($"Вам подходит класс - {pers[i].specCharacter}");
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите предпочитаемый урон для игры");
                            int damageSpec = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите предпочитаемый класс для игры");
                            string spec = Console.ReadLine();
                            for (int i = 0; i < pers.Length; i++)
                            {
                                if (spec == pers[i].specCharacter && damageSpec > pers[i].damageCharacter || damageSpec == pers[i].damageCharacter)
                                {
                                    Console.WriteLine($"Вам подходит класс - {pers[i].specCharacter}, у которого урон {pers[i].damageCharacter}");
                                }
                                else
                                {
                                    Console.WriteLine($"К сожалению, данный класс вам не подходит. У класса - {pers[i].specCharacter} урон - {pers[i].damageCharacter}");
                                }
                            }
                            break;
                        }
                }
            }
        }
    }
    class Character
    {
        public string nameCharacter;
        public string specCharacter;
        public int damageCharacter;
    }
}
