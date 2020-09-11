using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6Methods
{
    public class Parameters
    {
        //PARAMETERS

        //Methods can optionally include a set of parameters as inputs
        //Each parameter needs a type and a name
        //The concrete values given to a method when it is invoked are called *arguments*.
        public int Add(int param1, int param2) //param1 and param2 are parameters, both of type int
        {
            return param1 + param2;
        }

        //This method is used in the Program.cs file.

        //REF KEYWORD

        //We can pass parameters by reference using the *ref* keyword.
        //Invocation of the below method is in the Program.cs file.
        //Ref parameters must be initialized (given a value) before being
        //passed as arguments.
        public void Sum(ref int total, int second)
        {
            total = total + second;
        }

        //IN KEYWORD

        //We might also want to pass a parameter by reference but not allow
        //the method to change that parameter's value.
        //For this, we use the *in* keyword.
        //Invocation of this method is in the Program.cs file.
        public double GetCircumference(double radius, in double pi)
        {
            //pi = 3.14285; //Uncomment this line to get an error.
            return 2 * pi * radius;
        }

        //PARAMS KEYWORD

        //We can pass an arbitrary number objects of the same type 
        //to a method using the *params* keyword.
        public decimal GetTotalPriceForSeats(params decimal[] seatPrices) 
        {
            return seatPrices.Sum(); //Discussed in Part 14 - LINQ Basics
        }

        //OPTIONAL PARAMETERS

        //Parameters in methods are "optional" if fit two conditions:
        //1. They are given a "default" value that will be used if no other value is passed in AND
        //2. They are listed after all required parameters.
        public int Increment(int startValue, int increment = 1)
        {
            return startValue + increment;
        }

        //NAMED ARGUMENTS

        //We can even pass arguments to methods "out of order" if we know the parameter names.
        public double GetPyramidVolume(int height, int baseArea)
        {
            return 0.33333333333 * height * baseArea;
        }

    }
}
