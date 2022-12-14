using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_5_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Visitor[] arr = new Visitor[5];
            int indexName = 0;
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
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] != null && arr[i].name == name)
                            {
                                approve = false;
                            }
                        }
                        if (approve)
                        {
                            arr[indexName] = new Visitor();
                            arr[indexName].name = name;
                            indexName++;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите имя гостя для проверки");
                        string nameVisitor = Console.ReadLine();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] != null && arr[i].name == nameVisitor)
                            {
                                Console.WriteLine("Данный гость уже существует");
                            }
                        }
                        break;
                    case 3:
                        //Console.WriteLine("Введите индекс гостя, которого хотите удалить");
                        //int deleteVisitor = int.Parse(Console.ReadLine());
                        //arr[deleteVisitor] = arr[indexName - 1];
                        //arr[deleteVisitor] = null;
                        //indexName--;
                        Console.WriteLine("Введите имя гостя, которого хотите удалить");
                        string deleteVisitor = Console.ReadLine();
                        arr[deleteVisitor] = arr[indexName - 1];
                        arr[deleteVisitor] = null;
                        indexName--;
                        Console.WriteLine("Вы удалили гостя");
                        break;
                    case 4:
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] != null)
                            {
                                arr[i].PrintVisitorName();
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("До новых встреч");
                        break;
                }
            }
        }
    }

}

class Visitor
{
    public string name;

    public void PrintVisitorName()
    {
        Console.WriteLine(name);
    }
}

