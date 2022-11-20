using System;
using System.Collections.Generic;
using System.Text;

namespace Kpyap_11
{
    class Catalogs : IWorkArr
    {
        private Catalog[] arrCatalogs;

        public Catalogs(Catalog[] arrCatalogs)
        {
            this.arrCatalogs = arrCatalogs;
        }
        public Catalogs() { }

        public object CreateArray()
        {
            Catalog[] catalogs = new Catalog[5];
            Catalog temp = new Catalog();
            for (int i = 0; i < catalogs.Length; i++)
            {
                catalogs[i] = (Catalog)temp.Create();
            }
            Catalogs arrCatalogs = new Catalogs(catalogs);
            return arrCatalogs;
        }
        public void ShowInfo()
        {
            for (int i = 0; i < arrCatalogs.Length; i++)
            {
                Console.WriteLine(arrCatalogs[i]);
                Console.WriteLine("+ - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +");
            }
        }

        public void Sort()
        {
            Catalog temp;
            for (int i = 0; i < arrCatalogs.Length; i++)
            {
                for (int j = 0; j < arrCatalogs.Length - 1; j++)
                {
                    if (arrCatalogs[j].Name.Length > arrCatalogs[j + 1].Name.Length)
                    {
                        temp = arrCatalogs[j + 1];
                        arrCatalogs[j + 1] = arrCatalogs[j];
                        arrCatalogs[j] = temp;
                    }
                }
            }
        }
        public static int Value(Catalog temp, int value)
        {
            switch (value)
            {
                case 1: return temp.Name.Length;
                case 2: return temp.TimeOfStart.Year;
                case 3: return temp.CountOfFiles;
                default:
                    return 0;
            }
        }
        public void SortingByArguments(int value)
        {
            Catalog temp;
            for (int i = 0; i < arrCatalogs.Length; i++)
            {
                for (int j = 0; j < arrCatalogs.Length - 1; j++)
                {
                    if (Value(arrCatalogs[j], value) > Value(arrCatalogs[j + 1], value))
                    {
                        temp = arrCatalogs[j + 1];
                        arrCatalogs[j + 1] = arrCatalogs[j];
                        arrCatalogs[j] = temp;
                    }
                }
            }
        }
        
    }
}