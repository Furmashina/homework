using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7_ex_1
{
    internal class Car
    {
        //Создать класс Car с полями: модель, объем двигателя, цвет, цена.
        //Два автомобиля считаются одинаковыми, если совпадает модель, объем двигателя и цвет.
        //Переопределите методы equals, toString.
        public string modelCar;
        public int engineSize;
        public string colorCar;
        public int priceCar;

        public Car(string modelCar, int engineSize, string colorCar, int priceCar)
        {
            this.modelCar = modelCar;
            this.engineSize = engineSize;
            this.colorCar = colorCar;
            this.priceCar = priceCar;
        }

        public override bool Equals(object obj)
        {
            Car car = (Car)obj;
            return car.engineSize == engineSize;
        }

        public override string ToString()
        {
            return modelCar + " " + engineSize + " " + colorCar + " " + priceCar;
        }
    }
}
