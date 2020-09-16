using System;

namespace _2PrimitiveTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRIMITIVE TYPES
            //"Primitive" types in C# are types that are so common that the language itself
            //supports them. They include number and non-number types.

            //NUMBER TYPES

            //The most basic of the primitive types in C# are the integral numeric types.
            //These types represent whole numbers.

            int one = 1;
            short three = 3;
            long hundred = 100;
            byte eight = 8;

            //Of the integral numeric types, int is the default and most basic.
            //A int represents a 32-bit integer.
            int five = 5;
            int thirteenHundred = 1300;
            int negativeForty = -40;
            int maxValueInt = 2147483647; //(2^32 - 1)

            //A short represents a 16-bit integer
            short two = 2;
            short negativeOneHundred = -100;
            short maxValueShort = 32767; //(2^16 - 1)

            //A long represents a 64-bit integer
            long fifty = 50;
            long maxValue = 9223372036854775807; //(2^64 - 1)

            //A byte represents an 8-bit integer, but can only 
            //represent positive (greater than 0) values.
            byte four = 4;
            byte maxValueByte = 255; //(2^8 - 1)

            //Integral types are normally signed, meaning they can represent
            //both positive and negative values.
            //The exception is byte; it is unsigned and can only represent positive values.

            //If we want to have unsigned integral types, we can use their unsigned equivalents.
            ushort unsignedShortMax = 65535;
            uint unsignedIntMax = 4294967295;
            ulong unsignedLongMax = 18446744073709551615;

            //We can also represent a signed byte
            sbyte signedByteMin = -127;

            //FLOATING-POINT NUMERIC TYPES
            Console.WriteLine("---------------------Floating-Point Numeric Types-----------------------");

            //Floating-point numbers represent non-whole numbers.
            //They are used to do more complex math calculations.

            //A double is an 8-byte number
            double fortytwo = 42.0;
            double pi = 3.14159;

            //A float is a 4-byte number
            float negativethirty = -30.0F;
            float eighteenhundrendandahalf = 1800.5F;

            //When using double or float, precision is lost when doing calculations.
            var sum = 0.1 + 0.2;
            Console.WriteLine(sum); //Output: 0.30000000000000004

            //Precision is sacrificed to gain speed; calculations involving non-whole numbers
            //are computationally expensive.

            //If we cannot lose precision, we use the decimal type
            decimal dollars = 1.45M;
            decimal billionaire = 1000000000.01M;

            //Decimal is generally used for money or currency calculations;
            //a loss of precision in those scenarios is not desired.

            //When we combine number types, the output is often the least-constrained type.
            //For example, combining an int and a double results in a double
            int myNum = 4;
            double myDouble = 6.8;

            var result = myNum + myDouble; //Type double
            Console.WriteLine(myNum + " + " + myDouble + " = " + result);

            //Mixing integral types and decimals results in a decimal.
            short myShort = 9;
            decimal myMoney = 2.22M;

            var result2 = myShort + myMoney;
            Console.WriteLine(myShort + " + " + myMoney + " = " + result2);

            //NON-NUMBER TYPES
            Console.WriteLine("---------------------Non-Number Types-----------------------");

            //We can use bool to represent a value that must be true or false.
            bool isTrue = true;
            bool isFalse = false;
            bool myBool; //Default is false

            //Char represents a single character.
            char a = 'a';
            char ampersand = '&';
            char x = 'x';
            char comma = ',';
            char semicolon = ';';
            char greekQuestionMark = ';'; //Great for pranks!

            //String represents text, or a collection of characters
            //Unlike the other primitive types, string is a reference type.
            string sentence = "This is a sentence.";
            string otherSentence = "This is another sentence.";
            string isNull; //Because string is a reference type, if we do
                           //not give it a value at instantiation, its value
                           //will be null.

            //DATETIME
            Console.WriteLine("------------------DateTime-------------------");
            //The type DateTime represents a point in time, typically expressed
            //as a date and a time.
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime(2020, 3, 15); //15 March 2020
            DateTime date3 = new DateTime(2020, 3, 15, 10, 30, 00); //15 March 2020, 10:30 AM

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);

            //LITERAL VALUES

            //In C#, if we write this code:
            var myValue = 7.8;

            //myValue is of type double, because that is the default value
            //for a number with a decimal point.

            //If instead, we want it to be a float, we use the literal identifier F
            var myFloat = 7.8F;

            //We can also use the literal identifier M for decimal types
            var myDecimal = 7.8M;

            //There are many kinds of these literal markers.
            var myDouble2 = 5.6D; //double
            var myLong = 568373L; //Type long, will be type ulong if the value is too large
            var myUnsignedInt = 98765U; //Type uint, will be type ulong if the value is too large

            //NULLABLE VALUES
            Console.WriteLine("---------------Nullable Values----------------");

            //We can declare a nullable variable by using the ? operator.
            char? c = null;
            double? myDouble4; //Value will be null
            decimal? myMoney2 = 45.61M;
            bool? trueFalseOrNotFound = false;
            int? myNumber = null;
            float? myFloat2 = 6.3F;

            //Nullable values will have null as their default value.
            int? myNullableInt2;

            //We can only use nullable on value types; reference types can already be null.

            //Uncomment the below line to get an error.
            //string? myNullableString = "This will not work.";

            //When types are made nullable, they are given two special properties:
            //HasValue and Value. We can use these properties to check for null:

            int? myNullableValue = 5;

            if (myNullableValue.HasValue)
            {
                Console.WriteLine(myNullableValue.Value); //Output: 5
            }

            int? myNullableValue2 = null;

            if (myNullableValue2.HasValue)
            {
                Console.WriteLine(myNullableValue2.Value); //Line does not execute, 
                                                           //since myValue2 is null
            }

            Console.ReadLine();
        }
    }
}
