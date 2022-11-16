using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4_ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 8 Создать массив, хранящий паспортные данные пользователя.Допустим паспорт содержит данные:
            //серия, номер и имя.
            //Необходимо создать три массива, которые будут хранить данные паспорта.
            //Данные в массивах должны храниться таким образом, чтобы данные одного паспорта хранились под одинаковым индексом во всех массивах.
            //В мейне создать консольное меню:
            //1.Добавить паспорт
            //2.Вывести все паспорта
            //3.Удалить паспорт
            //4.Проверить паспорт на существование
            //5.Выход
            int[] ser = new int[3];
            int[] numb = new int[3];
            string[] name = new string[3];
            int index = 0;

            int input = 0;
            while (input != 5)
            {
                Console.WriteLine("1. Добавить паспорт");
                Console.WriteLine("2. Вывести все паспорта");
                Console.WriteLine("3. Удалить паспорт");
                Console.WriteLine("4. Проверить паспорт на существование");
                Console.WriteLine("5. Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        bool seraiApprove = true;
                        bool numberApprove = true;
                        Console.WriteLine("Введите серияю паспорта");
                        int seria = int.Parse(Console.ReadLine());
                        for (int i = 0; i < ser.Length; i++)
                        {
                            if (seria == ser[i])
                            {
                                seraiApprove = false;
                            }
                        }
                        Console.WriteLine("Введите номер паспорта");
                        int nomer = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numb.Length; i++)
                        {
                            if (nomer == numb[i])
                            {
                                numberApprove = false;
                            }
                        }
                        Console.WriteLine("Введите имя паспорта");
                        string imya = Console.ReadLine();
                        if (seraiApprove && numberApprove)
                        {
                            ser[index] = seria;
                            numb[index] = nomer;
                            name[index] = imya;
                            index++;
                            Console.WriteLine("Паспорт добавлен");
                        }
                        else
                        {
                            Console.WriteLine("Паспорт не добавлен");
                        }
                        break;
                    case 2:
                        //Все три массива имеют одинаковую длину, поэтому не важно, по какому из них запускать цикл
                        for (int i = 0; i < ser.Length; i++)
                        {
                            Console.WriteLine(ser[i] + " " + numb[i] + " " + name[i]);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("напишите индекс: ");
                            int idx = int.Parse(Console.ReadLine());
                            ser[idx] = ser[index - 1];
                            numb[idx] = numb[index - 1];
                            name[idx] = name[index - 1];
                            ser[idx] = 0;
                            numb[idx] = 0;
                            name[idx] = null;
                            index--;
                            break;
                        }
                    case 4:
                        {
                            //для проверки наличия паспорта важно не только проверить, что серия, номер, имя существут в массивах, нужно еще проверить, что они находястя под одним индексом
                            int idx = -1; //начальное значение -1 означает, что это не существующий индекс
                            Console.WriteLine("Проверим паспорт на существование");
                            Console.WriteLine("Введите серию паспорта");
                            int seria1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите номер паспорта");
                            int nomer1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите имя паспорта");
                            string name1 = Console.ReadLine();
                            for (int i = 0; i < ser.Length; i++)
                            {
                                if (seria1 == ser[i])
                                {
                                    idx = i;
                                }
                            }
                            //проверяем, что нашли индекс серии
                            if (idx == -1)
                            {
                                Console.WriteLine("Паспорт не существует");
                            }
                            else
                            {
                                //проверяем ,что номер и имя юзера совпадают с номером и именем под этим индексом
                                if (nomer1 == numb[idx] && name1 == name[idx])
                                {
                                    Console.WriteLine("Паспорт существует");
                                }
                                else
                                {
                                    Console.WriteLine("Паспорт не существует");
                                }
                            }


                            break;
                        }
                    case 5:
                        Console.WriteLine("Вы вышли из программы");
                        break;
                }
    }
}
