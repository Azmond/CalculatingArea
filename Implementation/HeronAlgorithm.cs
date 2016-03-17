using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatingArea.Interface;
using CalculatingArea.Excerption;

namespace CalculatingArea.Implementation
{
    public class HeronAlgorithm : IAlgorithmCalcArea 
    {
        public HeronAlgorithm() {}

        public double Calculating(double a, double b, double c)
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

}
