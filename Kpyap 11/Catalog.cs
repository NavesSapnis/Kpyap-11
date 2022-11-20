using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kpyap_11
{

    class Catalog : ICloneable, IComparable,IWork , IComparer<Catalog>
    {

        private string name;
        private DateTime timeOfStart;
        private int countOfFiles;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime TimeOfStart
        {
            get { return timeOfStart; }
            set
            {
                DateTime maxDate = DateTime.Now;
                if (value > maxDate)
                {
                    timeOfStart = maxDate;
                }
                else
                {
                    timeOfStart = value;
                }

            }
        }
        public int CountOfFiles
        {
            get { return countOfFiles; }
            set
            {
                if (value < 0)
                {
                    countOfFiles = 1;
                }
                else
                {
                    countOfFiles = value;
                }

            }
        }
        public Catalog(string name, DateTime timeOfStart, int countOfFiles)
        {
            Name = name;
            TimeOfStart = timeOfStart;
            CountOfFiles = countOfFiles;
        }
        public Catalog() { }
        public object Create()
        {
            Random random = new Random();
            string[] fileName = { "ahk", "sqlPack", "Remix", "csgo500", "lr3", "sandbox", "bin", "vzlom", "Питонист хуже пидораса"};
            DateTime randomDate = new DateTime(random.Next(2000,2023), random.Next(1, 13), random.Next(1, 31), 0, 0, 0);
            Catalog catalog = new Catalog(fileName[random.Next(0,9)], randomDate, random.Next(1, 100));
            return catalog;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Название = { Name}\nДата создания = {TimeOfStart}\nКол-во файлов = {CountOfFiles}");
        }
        public object Clone()
        {
            return new Catalog(Name, TimeOfStart, CountOfFiles);
        }
        public override string ToString()
        {
            return $"Название = { Name}\nДата создания = {TimeOfStart}\nКол-во файлов = {CountOfFiles}";
        }
        public int CompareTo(object obj)
        {
            Catalog temp = (Catalog)obj;
            return Math.Sign(this.CountOfFiles - temp.CountOfFiles);
        }
        public int Compare(Catalog? p1, Catalog? p2)
        {
            return p1.Name.Length - p2.Name.Length;
        }

        public Catalog[] RandomCatalogs()
        {
            Catalog[] catalogs = new Catalog[5];
            Catalog temp = new Catalog();
            for (int i = 0; i < catalogs.Length; i++)
            {
                catalogs[i] = (Catalog)temp.Create();
            }
            return catalogs;
        }
    }
}
