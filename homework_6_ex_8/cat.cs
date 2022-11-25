using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_ex_8
{
    internal class cat
    {
        //Задача 2 Создать класс Cat с полями имя, возраст, любимое блюдо.Поле имя является обязательным, остальные нет.
        //Создать несколько перегруженных конструкторов, которые будут связаны между собой для инициализации полей.
        //Создать метод print, который будет выводить на консоль значения всех полей.
        public string Name;
        public int Age;
        public string FaforiteDish;

        public cat(string name)
        {
            Name = name;
        }

        public cat(string name, int age) : this(name)
        {
            Age = age;
        }

        public cat(string name, int age, string faforiteDish) : this(name, age)
        {
            FaforiteDish = faforiteDish;
        }

        public void Print()
        {
            Console.WriteLine($"Имя кота - {Name}, ему {Age} лет, любит покушать {FaforiteDish}");
        }
    }
}
