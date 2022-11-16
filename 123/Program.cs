using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Visitor[] arr = new Visitor[5];
            int index = 0;
            int input = 0;
            while (input != 5)
            {
                Console.WriteLine("1. Добавить гостя");
                Console.WriteLine("2. Проверить есть ли имя гостя в списке приглашенных");
                Console.WriteLine("3. Исключить гостя(юзер вводит индекс)");
                Console.WriteLine("4. Вывести всех приглашенных");
                Console.WriteLine("5. Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        bool approve = true;
                        Console.WriteLine("Введите имя гостя");
                        string name = Console.ReadLine();
                        for (int i = 0; i < arr.Length - 1; i++)
                        {
                            if (arr[i] != null && arr[i].name == name)
                            {
                                approve = false;
                            }
                        }
                        if (approve)
                        {
                            arr[index] = new Visitor(name);
                            index++;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < arr.Length - 1; i++)
                        {
                            if (arr[i] != null)
                            {
                                arr[i].PrintVisitorName();
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите индекс гостя");
                        int indexVisitor = int.Parse(Console.ReadLine());
                        arr[indexVisitor] = arr[index - 1];
                        index--;
                        break;
                }
            }
        }
    }

}

class Visitor
{
    public string name;
    public Visitor(string name)
    {
        this.name = name;
    }

    public void PrintVisitorName()
    {
        Console.WriteLine(name);
    }
}