using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatingArea.Excerption
{
    public class ZeroValueException : ArithmeticException
    {

        public ZeroValueException(string message)
            : base(message)
        {
        }
    }
}
