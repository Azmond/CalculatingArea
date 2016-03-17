using CalculatingArea.Excerption;
using CalculatingArea.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatingArea.Implementation
{
    public class TriangleCalculatingArea : ICalculatingArea
    {
        private double _a_side = 0d, _b_side = 0d, _c_side = 0d;
        private IAlgorithmCalcArea _algorithm=null;

        public TriangleCalculatingArea(IAlgorithmCalcArea Algorithm, double a_length, double b_length, double c_length)
        {
            _a_side = CheckNegtiveOrZero(a_length);
            _b_side = CheckNegtiveOrZero(b_length);
            _c_side = CheckNegtiveOrZero(c_length);
            _algorithm = Algorithm;
            CheckSide();
        }

        public double Calculating()
        {
            if (_algorithm != null)
                return _algorithm.Calculating(_a_side, _b_side, _c_side);
            else
                return -1;
        }

        private double CheckNegtiveOrZero(double value)
        {
            if (value < 0)
            {
                throw new NegativeValueException("Value can not be negative");
            }
            if (Math.Round(value,0) == 0)
            {
                throw new ZeroValueException("Value can not be zero");
            }
            return value;
        }

        private void CheckSide()
        {
            if (_a_side > (_b_side + _c_side) || _b_side > (_a_side + _c_side) || _c_side > (_a_side + _b_side))
            {
                throw new TriangleSideException("Incorrectly set triangle");
            }
            return;
        }


    }
}
