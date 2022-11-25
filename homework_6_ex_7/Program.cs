using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1 Создать класс Rectangle с полями a, b (стороны), цвет, поверхность. Поля a, b являются обязательными для заполнения, остальные нет.
            //Создать перегруженные версии конструкторов, с помощью которых можно проинициализировать объект разными способами, но каждый из которых включает обязательные поля.
            //Создать метод print, который будет выводить значения полей.
            //В мейне создать несколько объектов, задействуя все конструкторы и вывести информацию о них на консоль.
            Rectangle rec1 = new Rectangle(5, 10);
            rec1.Ptintinfo();
            Rectangle rec2 = new Rectangle(5, 10, "Черный");
            rec2.Ptintinfo();
            Rectangle rec3 = new Rectangle(5, 10, "Черный", "Матовая?");
            rec3.Ptintinfo();
        }
    }
}
