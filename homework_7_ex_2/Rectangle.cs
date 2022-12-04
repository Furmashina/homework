using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homework_7_ex_2
{
    internal class Rectangle
    {
        //Создать класс Rectangle с полями цвет, стороны a и b.Создать конструктор и метод, возвращающий площадь прямоугольника.
        //Два прямоугольника считаются одинаковыми, если их цвет и площадь одинаковые.
        public int a;
        public int b;
        public string color;

        public Rectangle(int a, int b, string color)
        {
            this.a = a;
            this.b = b;
            this.color = color;
        }

        public int Square()
        {
            return a * b;
        }
        public override string ToString()
        {
            return a + " " + b + " " + color + " ";
        }

        public override bool Equals(object obj)
        {
            Rectangle rec = (Rectangle)obj;
            return rec.color == color && rec.Square() == Square();
        }
    }
}
