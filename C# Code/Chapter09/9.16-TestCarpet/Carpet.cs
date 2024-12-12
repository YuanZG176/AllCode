using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Carpet  地毯
//MOTTO   座右铭

namespace _9._16_TestCarpet
{
    internal class Carpet
    {
        public const string MOTTO = "Our carpets are quality-made";
        private int length;
        private int width;
        private int area;

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
                CalcArea();
            }
            
        }



        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                CalcArea();
            }

        }

        public int Area
        {
            get
            {
                return area;
            }
        }


        private void CalcArea()
        {
            area = Length * Width;
        }

    }


}
