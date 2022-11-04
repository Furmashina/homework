using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1 Допустим, есть два игрока. Пользователь вводит с консоли имя первого игрока и количество его очков,
            //далее - имя второго игрока и количество его очков. Программа должна определить победителя и вывести его имя на консоль, либо вывести "Ничья".

            Random rnd = new Random();
            
            Console.Write("Enter name Player1 = ");
            string player1 = Console.ReadLine();

            Console.Write("Enter name Player2 = ");
            string player2 = Console.ReadLine();

            //Console.Write("Enter points Player1 = ");
            //int point1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter points Player2 = ");
            //int point2 = int.Parse(Console.ReadLine());

            int point1 = rnd.Next(1, 10);
            int point2 = rnd.Next(1, 10);

            if (point1 == point2)
            {
                Console.Write("Friendly Draw");
            }
            else if (point1 > point2)
            {
                Console.Write("Player 1 wins! Fatality");
            }
            else
            {
                Console.Write("Player 2 wins! Brutality");
            }
            Console.WriteLine();

         
        }
    }
}
