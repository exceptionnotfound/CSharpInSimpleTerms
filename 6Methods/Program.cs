using System;

namespace _6Methods
{
    class Program
    {
        //METHOD BASICS

        //Go to the class Methods.cs to start this lesson.

        public static void Main(string[] args)
        {
            Methods myMethods = new Methods();
            var result = myMethods.GetHello("Jen"); //Method invocation
            Console.WriteLine(result);

            myMethods.DoSomething(); //Method has "void" return type, so nothing will be returned.

            //PARAMETERS
            Parameters myParameters = new Parameters();
            int value1 = 5; //Used as arguments below
            int value2 = 16;

            int sum = myParameters.Add(value1, value2); //Sum == 21
            Console.WriteLine(sum);


            //OUT KEYWORD
            //Occassionally we want to pass out multiple values from a single method.
            //We can pass parameters using the *out* keyword to specify this.
            string intString = "5";
            bool hasValue = int.TryParse(intString, out int intResult); //Result is now 5

            Console.WriteLine(hasValue.ToString());
            if (hasValue)
            {
                Console.WriteLine(intResult);
            }

            //REF KEYWORD
            int total = 17;
            int nextNumber = 2;

            myParameters.Sum(ref total, nextNumber); //total is now 19
            myParameters.Sum(ref total, 6); //total is now 25
            Console.WriteLine(total);

            //IN KEYWORD 
            double pi = 3.14159;
            var circumference = myParameters.GetCircumference(4.5, pi);
            Console.WriteLine(circumference);

            //PARAMS KEYWORD
            var totalPrice = myParameters.GetTotalPriceForSeats(90, 91, 92, 93, 94);
            Console.WriteLine(totalPrice); //460

            //OPTIONAL PARAMETERS
            int byOne = myParameters.Increment(10); //11
            Console.WriteLine(byOne);

            int byFive = myParameters.Increment(10, 5); //15
            Console.WriteLine(byFive);

            //NAMED ARGUMENTS
            //The parameter "height" is listed first, but by using the parameter names
            //as labels for the arguments, we can pass them out of order.
            var volume = myParameters.GetPyramidVolume(baseArea: 12, height: 4);
            Console.WriteLine("Volume is " + volume.ToString());
        }
    }
}
