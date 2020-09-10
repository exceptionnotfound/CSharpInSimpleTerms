using System;
using System.Collections.Generic;
using System.Text;

namespace _12ExceptionHandling
{
    //Custom exception classes must inherit from System.Exception in order for
    //C# to treat them like exceptions.
    public class CustomException : Exception
    {
        public CustomException(string message) { /*...*/ }
    }
}
