using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Yuan
{
    internal class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("不能除以零");
            return a / b;
        }
        public (double sum, double difference) AddAndSubstract(double a, double b)
        {
            double sum = a + b;
            double difference = a - b;
            return (sum, difference);
        }

    }

}
