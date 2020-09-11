using System;
using System.Collections.Generic;
using System.Text;

namespace _15Generics
{
    public static class SwapMethods
    {
        //GENERIC METHODS

        //Instead of implementing an entire generic class, sometimes we might
        //just want generic methods when a class might be overkill.
        public static void Swap<T>(ref T first, ref T second)
        {
            T temp;
            temp = first;
            first = second;
            second = temp;
        }

        //Go back to Program.cs to see how we invoke this method.
    }
}
