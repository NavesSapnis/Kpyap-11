using System;
using System.Collections.Generic;
using System.Text;

namespace Kpyap_11
{
    
    class Catalog
    {
        
        private string name;
        private DateTime timeOfStart;
        private int countOfFiles;

        public string Name
        {
            get { return name; }
            set {  name = value; }
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
    }
}
