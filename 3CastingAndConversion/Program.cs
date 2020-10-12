using System;

namespace _3CastingAndConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //CASTING
            Console.WriteLine("---------------------Casting-----------------------");

            //"Casting" is the act of taking a value of one type and attempting
            //to "force" that value to be another type. 
            //We cast a variable to another type by putting the desired type in ()
            int five = 5;
            var doubleFive = (double)five;
            Console.WriteLine(doubleFive);

            char a = 'a';
            var valueA = (int)a;
            Console.WriteLine(valueA);

            float myFloat = 4.56F;
            decimal myMoney = (decimal)myFloat;
            Console.WriteLine(myMoney);

            //This will work, provided the value in the original type is also
            //a valid value in the new type.

            //However, some casts will fail because there is no implicit
            //way to convert the value.
            string myString = "This is a sentence";

            //Uncomment the below line to get a compilation error.
            //byte myByte = (byte)myString;

            //Some casts will also result in a loss of precision:
            decimal myMoney2 = 5.87M;
            int intMoney = (int)myMoney2; //Value is now 5; the .87 was lost
            Console.WriteLine(intMoney);

            //Because of this, we must be careful when casting more-precise types
            //(e.g. double, float, decimal) to less-precise types (e.g. int, long, short, etc.)

            //CONVERSION
            Console.WriteLine("---------------------Conversion-----------------------");

            //A conversion is similar to a cast in that it takes a value and 
            //converts it from one type to another. However, conversion is generally
            //more forgiving than casting.

            int myFour = 4;
            decimal decFour = Convert.ToDecimal(myFour);
            Console.WriteLine(decFour);

            decimal myMoney3 = 5.67M;
            int intMoney2 = Convert.ToInt32(myMoney3); //Value is now 6; 
                                                      //the decimal value was rounded
            Console.WriteLine(intMoney2);

            //The Convert class can handle non-numeric to numeric conversions.
            string stringFive = "5.0";
            decimal decFive = Convert.ToDecimal(stringFive); //Value is 5.0
            Console.WriteLine(decFive);

            //The Convert class can also handle numeric to non-numeric conversions.
            double myValue = 5.33;
            string stringValue = Convert.ToString(myValue); //Value is "5.33"
            Console.WriteLine(stringValue);

            int intTrue = 1;
            bool isTrue = Convert.ToBoolean(intTrue); //Value is true because number is not 0
            Console.WriteLine(isTrue);

            //PARSE() AND TRYPARSE()
            Console.WriteLine("---------------------Parse() and TryParse()-----------------------");
            //The string type, being a reference type, needs to be converted
            //in a special manner; we call this *parsing*.

            //If we need to parse a string to a decimal, we could use the Parse() method.
            string decString = "5.632";
            decimal decValue = decimal.Parse(decString); //Value is 5.632M
            Console.WriteLine(decValue);

            //However, if the string cannot be parsed to the desired type
            //an exception will be thrown.
            string testString = "10.22.2000";
            //double decValue2 = double.Parse(testString); //Uncomment this line to get an exception.

            string intTest = "This is a test string";
            //int intValue = int.Parse(intTest); //Uncomment this line to get an exception.

            //For situations in which it is possible for the string to not have a value
            //that is parsable, we can use the TryParse() method.
            string value = "5.0";
            decimal result;
            bool isValid = decimal.TryParse(value, out result);

            //If isValid is true, the string was successfully parsed.

            //IS KEYWORD
            Console.WriteLine("---------------------is Keyword-----------------------");
            //Sometimes, we don't know the type of a given object.
            //C# provides the 'is' keyword to test if an object is of a specified type.
            var myUnknownValue = 6.5M; //M literal means type will be decimal
            if (myUnknownValue is decimal) {
                Console.WriteLine(myUnknownValue);
            }

            //AS KEYWORD
            Console.WriteLine("---------------------as Keyword-----------------------");
            //For reference types (e.g. string, classes, etc.) C# provides us with the
            //'as' keyword to convert one reference type to another.
            string testString2 = "This is a test"; //string is a reference type
            object objString = (object)testString2; //Cast the string to an object

            string test2 = objString as string; //Will convert to string successfully
            Console.WriteLine(test2);

            //Note that this only works for conversions that are known to exist;
            //If a valid conversion does not exist we get an error.

            var myClass = new ClassA(); //ClassA and ClassB defined in Classes.cs file
            //var newClass = myClass as ClassB; //Uncomment this line to get an exception.

            //GETTYPE() AND TYPEOF
            Console.WriteLine("---------------------GetType() and typeof-----------------------");
            //For any object in C#, we can get it's type by calling the GetType() method.
            var sentence = "This is a sentence.";
            var type = sentence.GetType();
            Console.WriteLine(type); //Output: System.String

            //We can also check if an object is of a known type using the *typeof* keyword.
            if (type == typeof(string)) 
            {
                Console.WriteLine("Type is string!");
            }
            else if (type == typeof(int)) 
            {
                Console.WriteLine("Type is int!");
            }
        }
    }
}
