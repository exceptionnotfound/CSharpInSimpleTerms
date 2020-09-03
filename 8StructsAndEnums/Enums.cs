using System;
using System.Collections.Generic;
using System.Text;

namespace _8StructsAndEnums
{
    //Enumerations are of type int by default, and when we create them,
    //we can specify the value we want each name to represent.
    public enum Color
    {
        Red = 1,
        Yellow = 2,
        Blue = 3,
        Green = 4
    }

    //We can also use the default values.
    public enum CardType
    {
        Resource, //0
        Science, //1
        Economic, //2
        Military //3
    }

    //If we don't want to use int, we can use any integral numeric type,
    //including short, long, and byte.
    public enum HairColor : short
    {
        Brown = 5,
        Blonde = 38,
        Red = 145,
        Black = 2,
        Grey = 42
    }

    //The below enum is used as a bitwise flag.
    //The attribute [Flags] specifies that it can be used this way.
    //Also, every value must be a power of 2. The powers are marked.
    [Flags]
    public enum Months
    {
        January = 1, //2^0
        February = 2, //2^1
        March = 4, //2^2
        April = 8, //2^3
        May = 16, //2^4
        June = 32, //2^5
        July = 64, //2^6
        August = 128, //2^7
        September = 256, //2^8
        October = 512, //2^9
        November = 1024, //2^10
        December = 2048 //2^11
    }
}
