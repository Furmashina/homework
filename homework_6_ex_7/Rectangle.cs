using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_ex_7
{
    internal class Rectangle
    {
        //Создать класс Rectangle с полями a, b (стороны), цвет, поверхность. Поля a, b являются обязательными для заполнения, остальные нет.
        //Создать перегруженные версии конструкторов, с помощью которых можно проинициализировать объект разными способами, но каждый из которых включает обязательные поля.
        //Создать метод print, который будет выводить значения полей.
        public int A;
        public int B;
        public string Color;
        public string Surface;

        public Rectangle(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public Rectangle(int a, int b, string color) : this(a, b)
        {
            Color = color;
        }

        public Rectangle(int a, int b, string color, string surface) : this(a, b, color)
        {
            Surface = surface;
        }

        public void Ptintinfo()
        {
            Console.WriteLine($"У данного прямоугольника сторона А - {A}, сторона B - {B}, цвет - {Color}, поверхность - {Surface}");
        }
    }
}
