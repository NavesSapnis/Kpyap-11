using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Kpyap_11
{
    class Program
    {

        public static int Menu(string text)
        {
            Console.WriteLine(text);
            int coise = Convert.ToInt32(Console.ReadLine());
            return coise;
        }
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            Catalog test1 = new Catalog("1", DateTime.Now, 423);
            Catalog test2 = new Catalog("2", DateTime.Now, 12);
            Catalog[] arr = new Catalog[5];
            while (true)
            {
                try
                {
                    switch (Menu("1 - Создать объект\n2 - клонировать объект\n3 - Создать массив объктов\n4 - вывести массив\n5 - Отсортировать"))
                    {
                        case 1:
                            Console.Clear();
                            switch (Menu("1 - определить явно\n2 - рандомно"))
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Введите название");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Введите дату создания");
                                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                                    Console.WriteLine("Введите число файлов");
                                    int count = Convert.ToInt32(Console.ReadLine());
                                    catalog = new Catalog(name, date, count);
                                    break;
                                case 2:
                                    Console.Clear();
                                    catalog = (Catalog)catalog.Create();
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Catalog fakeCatalog = (Catalog)catalog.Clone();
                            Console.WriteLine("Оригинальный объект");
                            catalog.ShowInfo();
                            Console.WriteLine("\nКлон объекта");
                            fakeCatalog.ShowInfo();

                            break;
                        case 3:
                            Console.Clear();
                            arr = catalog.RandomCatalogs();
                            break;
                        case 4:
                            Console.Clear();
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.WriteLine(arr[i] + "\n + - + - + - + - + - + - + - + - + - + - + - + - + - + - + - +");
                            }
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Выберите Дополнительный критерий сортировки");
                            switch (Menu("1 - Название\n2 - Кол-во файлов"))
                            {
                                case 1:
                                    Console.Clear();
                                    Array.Sort(arr, new Catalog());
                                    break;
                                case 2:
                                    Console.Clear();
                                    Array.Sort(arr);
                                    break;
                            }
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                }
            }
        }
    }
}

