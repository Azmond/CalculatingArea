using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatingArea.Interface;
using CalculatingArea.Excerption;

namespace CalculatingArea.Implementation
{
    public class IsoscelesAlgorithm : IAlgorithmCalcArea
    {

        public IsoscelesAlgorithm() { }

        public double Calculating(double a, double b, double c)
        {
            if (a > b && a > c)
            {
                return (b * c) / 2;
            }
            else if (b > c)
            {
                return (a * c) / 2;
            }
            else
            {
                return (a * b) / 2;
            }
        }
    }

}
