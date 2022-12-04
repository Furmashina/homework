using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7_ex_3
{
    internal class Planet
    {
        //Создать класс Planet:
        ////Дальше ваша реализация
        ////Две планеты считаются одинаковыми, если совпадают все поля.
        public int mass; //масса планеты
        public bool atmosphere; //true, если есть атмосфера, иначе - false
        public double gravity; //сила гравитации

        public Planet(int mass, bool atmosphere, double gravity)
        {
            this.mass = mass;
            this.atmosphere = atmosphere;
            this.gravity = gravity;
        }

        public override bool Equals(object obj)
        {
            Planet planet = (Planet)obj;
            return planet.mass == mass && planet.atmosphere == atmosphere && planet.gravity == gravity;
        }

        public override string ToString()
        {
            return mass + " " + atmosphere + " " + gravity;
        }
    }
}
