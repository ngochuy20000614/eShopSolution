using System;
using System.Collections.Generic;
using System.Text;

namespace eHocBongSolution.Utilities.Exceptions
{
    public class EHocBongException : Exception
    {
        public EHocBongException()
        {
        }

        public EHocBongException(string message)
            : base(message)
        {
        }

        public EHocBongException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
