using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace homework_7_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1 Создать класс Car с полями: модель, объем двигателя, цвет, цена.
            //В мейне создайте пару объектов класса Car, сравните их через equals, а также выведите на консоль через toString
            //Выполните такие же операции с объектами следующих классов:
            //Класс Rectangle с полями: a,b(стороны), цвет.
            //Два прямоугольника считаются одинаковыми, если совпадают стороны и цвет
            //Класс Passport с полями: серия, номер, имя, фамилия, отчество
            //Два паспорта считаются одинаковыми, если совпадают серия и номер
            //Класс Lamp(лампочтка) с полями: цвет лампы, цена, мощность (в вольтах)
            //Два лампочтки считаются одинаковыми, если совпадают цвет и мощность
            Car car1 = new Car("Хонда", 16, "Чорный", 150);
            Car car2 = new Car("Тойота", 16, "Белый", 200);
            Console.WriteLine(car1.Equals(car2));
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
        }
    }
}
