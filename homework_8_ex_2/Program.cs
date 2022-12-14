using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_8_ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2 Выполнить старую задачу через List.Вы можете создавать свои конструкторы / методы и прочее:
            //Создать класс Rectangle с полями цвет, стороны a и b.Создать конструктор и метод, возвращающий площадь прямоугольника. 
            //Два прямоугольника считаются одинаковыми, если их цвет и площадь одинаковые.
            //В мейне создать список прямоугольников и один прямоугольник:
            //int a = ваше значение;
            //int b = ваше значение;
            //string color = ваше значение;
            //Rectangle rec = new Rectangle(a, b, color);
            //Создать консольное меню:
            //1.Добавить прямогуольник
            //2.Вывести все прямоугольники(используйте toString)
            //3.Проверить, есть ли в массиве прямоугольник, ранвый rec(использовать Equals)
            //4.Выход
            List<Rectangle> rectangles = new List<Rectangle>();
            Rectangle rec1 = new Rectangle(2, 3, "green");
            int input = 0;
            while (input != 4)
            {
                Console.WriteLine("1. Добавить треугольник");
                Console.WriteLine("2. Вывести все прямоугольники");
                Console.WriteLine("3. Проверить есть ли в массиве схожие треугольники");
                Console.WriteLine("4. Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Введите сторону a");
                        int aRec = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите сторону б");
                        int bRec = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите цвет прямоугольника");
                        string colorRec = Console.ReadLine();
                        rectangles.Add(new Rectangle(aRec, bRec, colorRec));
                        break;
                    case 2:
                        for (int i = 0; i < rectangles.Count; i++)
                        {
                           Console.WriteLine(rectangles[i].ToString());
                        }
                        break;
                    case 3:
                        if (rectangles.Contains(rec1))
                        {
                            Console.WriteLine("Есть");
                        }
                        else
                        {
                            Console.WriteLine("нет");
                        }
                        break;
                }
            }
        }
    }
}
