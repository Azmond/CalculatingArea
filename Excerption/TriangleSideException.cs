using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatingArea.Excerption
{
    public class TriangleSideException : ArithmeticException
    {

        public TriangleSideException(string message)
            : base(message)
        {
        }

    }
}
