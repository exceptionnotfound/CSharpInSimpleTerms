using System;
using System.Collections.Generic;
using System.Text;

namespace _17AttributesAndReflection
{
    [Flags] //Attribute
    public enum DayOfWeek
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday = 64
    }
}
