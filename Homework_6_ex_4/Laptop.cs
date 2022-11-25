using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_ex_4
{
    internal class LaptopCard
    {
        //Создать класс Laptop(ноутбук) с полями:
        //int ram //оперативная память
        //int cores; //количество ядер в процессоре
        //int videoRam; //память видеокарты
        //Создать методы:
        //printInfo - выводит информацию о карте
        //calcFPS() - считает количество fps(количество кадров в секунду в игре) и возвращает посчитанное значение
        //fps считается по формуле: ram * 2 + cores * 3 + videoRam * 4.

        public int Ram;
        public int Cores;
        public int VideoRam;

        public LaptopCard(int ram, int cores, int videoRam)
        {
            this.Ram = ram;
            this.Cores = cores;
            this.VideoRam = videoRam;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"У данного ноутбука  - {Ram} GB оперативки, {Cores} ядер, и {VideoRam} GB оперативной памяти");
        }

        public int CalcFPS()
        {
            return Ram * 2 + Cores * 3 + VideoRam * 4;
        }
    }
}
