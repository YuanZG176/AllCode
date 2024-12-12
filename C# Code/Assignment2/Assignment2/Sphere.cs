using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Sphere
    {
        public double Length { get; private set; }
        //public virtual double Volume { get; }

        public Sphere(double length)
        {
            this.Length = length;
        }

        public virtual double Volume
        {
            get
            {
                double radius = Length / 2;
                return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            }
        }

        public double GetMass(double density)
        {
            return density * Volume;
        }


        /*        public double Length { get; private set; }
                public virtual double Volume { get; }

                public Sphere(double length)
                {
                    this.Length = length;
                }

                public virtual double CalculateVolume()
                {
                    double radius = Length / 2;
                    return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
                }*/
    }
}
