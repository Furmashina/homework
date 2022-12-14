using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_8_ex_2
{
    internal class Rectangle
    {
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
