using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Cube: Sphere
    {
        public Cube(double length) : base(length) { }
        public override double Volume
        {
            get
            {
                return Math.Pow(Length, 3);
            }
        }


        /*        public override double Volume => CalculateVolume();
                public Cube(double length):base(length) { }
                public override double CalculateVolume()
                {
                    return Math.Pow(Length, 3);
                }*/
    }
}
