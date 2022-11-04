using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace homeworkPlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1 Допустим, есть два игрока. Пользователь вводит с консоли имя первого игрока и количество его очков,
            //далее - имя второго игрока и количество его очков. Программа должна определить победителя и вывести его имя на консоль, либо вывести "Ничья".
            Console.Write("Enter name player 1 ");
            int player1 = int.Parse(Console.ReadLine());
            Console.Write("Enter date player 2 ");
            int player2 = int.Parse(Console.ReadLine());
            if (player1 == player2)
            {
                Console.WriteLine("draw");
            }
            else if (player1 > player2)
            {
                Console.WriteLine("Fatality");
            }
            else
            {
                Console.WriteLine("Brutality");
            }
            Console.WriteLine();
        }

    }
}
