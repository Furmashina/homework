using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3

            //В мейне создать массив планет и еще одну планету:
            //int mass = ваше значение;
            //bool atomosphere = ваше значение;
            //double gravity = ваше значение;
            //Planet planet = new Planet(mass, atomosphere, gravity);
            //Создать консольное меню:
            //1. Добавить планету
            //2. Вывести все планеты(используйте toString)
            //3. Проверить, есть ли в массиве планета, ранвая planet(использовать Equals)
            //4. Выход
            Planet[] arrPlanet = new Planet[5];
            Planet planet = new Planet(160, true, 15);
            int index = 0;
            int input = 0; 
            while (input != 4)
            {
                Console.WriteLine("1. Добавить планету");
                Console.WriteLine("2. Вывести все планеты");
                Console.WriteLine("3. Проверить есть ли в массиве наша планета");
                Console.WriteLine("4. Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Введите массу планеты");
                        int massPlanet = int.Parse(Console.ReadLine());
                        Console.WriteLine("Есть ли атмосфера на планете?");
                        bool atmosfere = bool.Parse(Console.ReadLine());//как тут сконвертировать)))))) Press F to pay respect...
                        Console.WriteLine("Введите силу гравитации");
                        int gravityPlanet = int.Parse(Console.ReadLine());
                        arrPlanet[index++] = new Planet(massPlanet, atmosfere, gravityPlanet);
                        break;
                    case 2:
                        for (int i = 0; i < arrPlanet.Length; i++)
                        {
                            if (arrPlanet[i] != null)
                            {
                                Console.WriteLine(arrPlanet[i].ToString());
                            }
                        }
                        break;
                    case 3:
                        //Нужно вывести один ответ: есть или нет
                        for (int i = 0; i < arrPlanet.Length; i++)
                        {
                            if (arrPlanet[i] != null)
                            {
                                Console.WriteLine(arrPlanet[i].Equals(planet));
                            }
                        }
                        break;
                }
            }
        }
    }
}
