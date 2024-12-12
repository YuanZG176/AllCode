using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Cone:Cylinder
    {
        public Cone(double length, double height) : base(length, height) { }
        public override double Volume
        {
            get
            {
                double radius = Length / 2;
                return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * Height;
            }
        }


        /*        public override double Volume => CalculateVolume();
                public Cone(double length,double height) : base(length, height) { }
                public override double CalculateVolume()
                {
                    double radius = Length / 2;
                    return (1.0/3.0)*Math.PI*Math.Pow(radius,2)*Height;
                }*/
    }
}
