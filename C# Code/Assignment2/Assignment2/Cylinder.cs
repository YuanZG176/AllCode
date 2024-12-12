using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Cylinder:Sphere
    {
        public double Height { get; private set; }
        public Cylinder(double length, double height) : base(length)
        {
            this.Height = height;
        }
        public override double Volume
        {
            get{
                double radius = Length / 2;
                return Math.PI * Math.Pow(radius, 2) * Height;
            }
        }



        /*        public double Height { get; private set; }
                public override double Volume => CalculateVolume();
                public Cylinder(double length,double height) : base(length)
                {
                    this.Height = height;
                }
                public override double CalculateVolume()
                {
                    double radius = Length / 2;
                    return Math.PI * Math.Pow(radius,2)*Height;
                }*/
    }
}
