using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2 Создать класс Cat с полями имя, возраст, любимое блюдо.Поле имя является обязательным, остальные нет.
            //Создать несколько перегруженных конструкторов, которые будут связаны между собой для инициализации полей.
            //Создать метод print, который будет выводить на консоль значения всех полей.
            //В мейне создать несколько объектов класса Cat, задействовав все конструкторы, вывести с помощью метода print значения полей каждого объекта
            cat cat1 = new cat("Тимоха");
            cat1.Print();
            cat cat2 = new cat("Тимоха", int.Parse(Console.ReadLine()));
            cat2.Print();
            cat cat3 = new cat("Тимоха", int.Parse(Console.ReadLine()), Console.ReadLine());
        }
    }
}
