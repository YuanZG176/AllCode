using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_原
{
    //auto-implemented properties
    internal class Rational:IComparable<Rational>
    {
        public int Numerator { get; private set; }//分子
        public int Denominator { get; private set; }//分母


        public Rational(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            Reduce();
        }

        public Rational()
        {
            Numerator = 0;
            Denominator = 1;
        }

        private void Reduce()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;

            if(Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            } 
        }

        private int GCD(int a, int b)
        {
            while(b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
        public void IncreaseBy(Rational other)
        {
            // (a/b) + (c/d) = (ad + bc) / bd
            Numerator = Numerator * other.Denominator + other.Numerator * Denominator;
            Denominator *= other.Denominator;
            Reduce();
        }
        public void DecreaseBy(Rational other)
        {
            // (a/b) - (c/d) = (ad - bc) / bd
            Numerator = Numerator * other.Denominator - other.Numerator * Denominator;
            Denominator *= other.Denominator;
            Reduce();
        }
        public void MultipleBy(Rational other)
        {
            // (a/b) * (c/d) = (ac) / (bd)
            Numerator *= other.Numerator;
            Denominator *= other.Denominator;
            Reduce();
        }

        public int CompareTo(Rational other)
        {
            int lcm = LCM(Denominator, other.Denominator);
            int thisNumer = Numerator * (lcm / Denominator);
            int otherNumer = other.Numerator * (lcm / other.Denominator);
            int returnVal;
            if (thisNumer > otherNumer)
                returnVal = 1;
            else
                if (thisNumer < otherNumer)
                    returnVal =  - 1;
                else
                    returnVal = 0;
            return thisNumer.CompareTo(otherNumer);
        }

        private int LCM(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
    }
}
