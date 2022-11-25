using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masssive
{
    internal class Laptop
    {
        public int Ram;
        public int Cores;
        public int VideoRam;

        public Laptop(int ram, int cores, int videoRam)
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
