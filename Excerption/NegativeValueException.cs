using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatingArea.Excerption
{
    public class NegativeValueException : ArithmeticException
    {

        public NegativeValueException(string message)
            : base(message)
        {
        }
    }

}
