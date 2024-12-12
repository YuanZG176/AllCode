using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Music
    {
        public string Name { get; set; }
        public string Style { get; set; }
        public string Singer { get; set; }
        public int Year { get; set; }

        public Music(string name, string singer,int year,string style)
        {
            this.Name = name;
            this.Singer = singer;
            this.Year = year;
            this.Style = style;
        }
    }
}
