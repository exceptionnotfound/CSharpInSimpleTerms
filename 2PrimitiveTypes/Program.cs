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

            //INTEGRAL NUMERIC TYPES
            Console.WriteLine("---------------------Integral Numeric Types-----------------------");
            //The most basic of the primitive types in C# are the integral numeric types.
            //These types represent whole numbers.

            int one = 1;
            Console.WriteLine("Int: " + one);
            short three = 3;
            Console.WriteLine("Short: " + three);
            long hundred = 100;
            Console.WriteLine("Long: " + hundred);
            byte eight = 8;
            Console.WriteLine("Byte: " + eight);

            //Of the integral numeric types, int is the default and most basic.
            //A int represents a 32-bit integer.
            Console.WriteLine("---------------------int------------------------");
            int five = 5;
            Console.WriteLine(five);
            int thirteenHundred = 1300;
            Console.WriteLine(thirteenHundred);
            int negativeForty = -40;
            Console.WriteLine(negativeForty);
            int intMaxValue = int.MaxValue; //(2^32 - 1)
            Console.WriteLine("Max Value:" + intMaxValue);

            //A short represents a 16-bit integer
            Console.WriteLine("---------------------short----------------------");
            short two = 2;
            Console.WriteLine(two);
            short negativeOneHundred = -100;
            Console.WriteLine(negativeOneHundred);
            short shortMaxValue = short.MaxValue; //(2^16 - 1)
            Console.WriteLine("Max Value: " + shortMaxValue);

            //A long represents a 64-bit integer
            Console.WriteLine("---------------------long-----------------------");
            long fifty = 50;
            Console.WriteLine(fifty);
            long longMaxValue = long.MaxValue; //(2^64 - 1)
            Console.WriteLine("Max Value: " + longMaxValue);

            //A byte represents an 8-bit integer, but can only 
            //represent positive (greater than 0) values.
            Console.WriteLine("---------------------byte-----------------------");
            byte four = 4;
            Console.WriteLine(four);
            byte byteMaxValue = byte.MaxValue; //(2^8 - 1)
            Console.WriteLine("Max Value: " + byteMaxValue);
            byte byteMinValue = byte.MinValue;
            Console.WriteLine("Min Value: " + byteMinValue);

            //Integral types are normally signed, meaning they can represent
            //both positive and negative values.
            //The exception is byte; it is unsigned and can only represent positive values.

            //If we want to have unsigned integral types, we can use their unsigned equivalents.
            Console.WriteLine("-------------------unsigned---------------------");
            ushort unsignedShortMax = ushort.MaxValue;
            Console.WriteLine("ushort Max Value: " + unsignedShortMax);
            uint unsignedIntMax = uint.MaxValue;
            Console.WriteLine("uint Max Value: " + unsignedIntMax);
            ulong unsignedLongMax = ulong.MaxValue;
            Console.WriteLine("ulong Max Value: " + unsignedLongMax);

            //We can also represent a signed byte
            Console.WriteLine("--------------------signed----------------------");
            sbyte signedByteMin = sbyte.MinValue;
            Console.WriteLine("sbyte Min Value: " + signedByteMin);
            sbyte signedByteMax = sbyte.MaxValue;
            Console.WriteLine("sbyte Max Value: " + signedByteMax);


            //FLOATING-POINT NUMERIC TYPES
            Console.WriteLine("---------------------Floating-Point Numeric Types-----------------------");

            //Floating-point numbers represent non-whole numbers.
            //They are used to do more complex math calculations.

            //A double is an 8-byte number
            Console.WriteLine("-------------------double---------------------");
            double fortytwo = 42.0;
            Console.WriteLine(fortytwo);
            double pi = 3.14159;
            Console.WriteLine(pi);

            //A float is a 4-byte number
            Console.WriteLine("-------------------float---------------------");
            float negativeThirty = -30.0F;
            Console.WriteLine(negativeThirty);
            float eighteenHundredAndAHalf = 1800.5F;
            Console.Write(eighteenHundredAndAHalf);

            //When using double or float, precision is lost when doing calculations.
            Console.WriteLine("-------------------precision---------------------");
            double sum = 0.1 + 0.2;
            Console.WriteLine(sum); //Output: 0.30000000000000004

            //Precision is sacrificed to gain speed; calculations involving non-whole numbers
            //are computationally expensive.

            //If we cannot lose precision, we use the decimal type
            Console.WriteLine("-------------------decimal---------------------");
            decimal dollars = 1.45M;
            Console.WriteLine(dollars);
            decimal billionaire = 1000000000.01M;
            Console.WriteLine(billionaire);

            //Decimal is generally used for money or currency calculations;
            //a loss of precision in those scenarios is not desired.
            Console.WriteLine("---------------Mixing Number Types-----------------");

            //When we combine number types, the output is often the least-constrained type.
            //For example, combining an int and a double results in a double
            int myNum = 4;
            double myDouble = 6.8;

            double result = myNum + myDouble; //Type double
            Console.WriteLine(myNum + " + " + myDouble + " = " + result);

            //Mixing integral types and decimals results in a decimal.
            short myShort = 9;
            decimal myMoney = 2.22M;

            decimal result2 = myShort + myMoney;
            Console.WriteLine(myShort + " + " + myMoney + " = " + result2);

            //NON-NUMBER TYPES
            Console.WriteLine("---------------------Non-Number Types-----------------------");

            //We can use bool to represent a value that must be true or false.
            Console.WriteLine("------------------bool--------------------");
            bool isTrue = true;
            Console.WriteLine(isTrue);
            bool isFalse = false;
            Console.WriteLine(isFalse);

            //Char represents a single character.
            Console.WriteLine("------------------char--------------------");
            char a = 'a';
            char ampersand = '&';
            char x = 'x';
            char comma = ',';
            char semicolon = ';';
            char greekQuestionMark = ';'; //Great for pranks!
            Console.WriteLine(a + " " + ampersand + " " + x + " " + comma + " " + semicolon + " " + greekQuestionMark);

            //String represents text, or a collection of characters
            //Unlike the other primitive types, string is a reference type.
            string sentence = "This is a sentence.";
            Console.WriteLine(sentence);
            string otherSentence = "The quick brown fox jumped over the lazy dog.";
            Console.WriteLine(otherSentence);
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
            Console.WriteLine("---------------------Literal Values-----------------------");

            //In C#, if we write this code:
            var myValue = 7.8;
            Console.WriteLine(myValue);

            //myValue is of type double, because that is the default value
            //for a number with a decimal point.

            //If instead, we want it to be a float, we use the literal identifier F
            var myFloat = 7.8F;
            Console.WriteLine(myFloat);
            //We can also use the literal identifier M for decimal types
            var myDecimal = 7.8M;
            Console.WriteLine(myDecimal);

            //There are many kinds of these literal markers.
            var myDouble2 = 5.6D; //double
            Console.WriteLine(myDouble2);
            var myLong = 568373L; //Type long, will be type ulong if the value is too large
            Console.WriteLine(myLong);
            var myUnsignedInt = 98765U; //Type uint, will be type ulong if the value is too large
            Console.WriteLine(myUnsignedInt);

            //NULLABLE VALUES
            Console.WriteLine("---------------Nullable Values----------------");

            //We can declare a nullable variable by using the ? operator.
            char? c = null;
            Console.WriteLine(c);
            double? myDouble4; //Value will be null
            //We cannot use myDouble4 in Console.WriteLine; if we do, we get a compilation error.
            decimal? myMoney2 = 45.61M;
            Console.WriteLine(myMoney2);
            bool? trueFalseOrNotFound = false;
            Console.WriteLine(trueFalseOrNotFound);
            int? myNumber = null;
            Console.WriteLine(myNumber);
            float? myFloat2 = 6.3F;
            Console.WriteLine(myFloat2);

            //Nullable values will have null as their default value.
            int? myNullableInt2;

            //We can only use nullables on value types; reference types can already be null.

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
