using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _18Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------EXPRESSIONS----------------------");
            //Expressions are a nebulous idea in C#. In short,
            //expressions are a set of operators and operands.
            //An individual expression can be a value, a variable,
            //an assignment, a property access, a method invocation,
            //and more.

            int myInt;
            long myLong = 6444296L; //This is two expressions, since both
                                    //values and assignments are expressions.
            DateTime myDate = DateTime.Now.AddDays(7); //This is also two expressions:
                                                       //a method invocation and an assignment.
            var sum = 6 + 7; //This is two expressions: an addition operation and an assignment.
            short? myNull = null; //This is ALSO two expressions, since null is an expression all by itself.
            bool hasValue = myNull.HasValue; //This is two expressions, an assignment and a property access.

            var height = 5;
            var width = 10;

            var message = $"The area of a rectangle with width {width} and height {height} is {width * height}";
            Console.WriteLine(message);

            Console.WriteLine("-------------------LAMBDAS---------------------");

            //A *lambda expression* is an expression that uses the "goes to" operator =>.
            //You can see some examples of this operator in the 14LINQBasics project.


            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var oddNumbers = numbers.Where(x => x % 2 != 0);
            foreach(var oddNumber in oddNumbers)
            {
                Console.Write(oddNumber + " ");
            }
            Console.WriteLine();

            var sumOfEven = numbers.Where(x => x % 2 == 0).Sum();
            Console.WriteLine($"Sum of even numbers is {sumOfEven}");

            //A lambda expression comes in two forms.
            //(input-parameters) => expression (This is an expression lambda)
            //(input-parameters) => { code_block } (This is a statement lambda)

            Console.WriteLine("-------------------DELEGATES-------------------");

            //Lambda expressions are also *delegates*. Delegates are
            //code blocks or expressions that optionally take inputs and return
            //and output, AND can be invoked at a time later than their creation.

            //We can manually create delegates using two different classes.
            //If our delegate needs to return a value, we use the Func<T> class.
            Console.WriteLine("-------------------Func<T>---------------------");
            var num = 64;
            Func<int, double> squareRoot = x => Math.Sqrt(x); //Expression lambda
            Console.WriteLine($"Square Root of {num} is {squareRoot(num)}");

            num = 144;
            Console.WriteLine($"Square Root of {num} is {squareRoot(num)}");

            Console.WriteLine("-------------------Action<T>-------------------");

            //If our delegate will NOT return a value, we use the Action<T> class.
            //Delegates can also access variables declared outside of the delegate.

            List<string> names = new List<string>();

            Action<string> sayHi = name =>
            {
                Console.WriteLine($"Hi {name}!");
                names.Add(name);
            }; //Statement lambda

            sayHi("Nicky");
            sayHi("Ravi");
            sayHi("Danielle");

            Console.Write("Names collection:");
            foreach (var name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            //Delegates can also be created using the *delegate* keyword, however
            //since this is not the recommended way to create them,
            //no examples of that will be included here.

            Console.WriteLine("-----------------A DELEGATE EXAMPLE-----------------");

            //Let's look at the following lines of code.
            var a = 10;
            var b = a + 5;
            var c = b % 5 == 0 ? b : a;

            //The last line of the above set breaks down into four expressions:
            //a modulus operation, a boolean comparison, a conditional, and an assignment.
            //We can create Func<T> functions for each of these, as well as
            //a combined Func<T> that invokes each of them in order.
            Func<int, int> modulus = x => { return x % 5; };
            Func<int, bool> boolCompare = x => { return x == 0; };
            Func<bool, int, int, int> conditional = (isTrue, x, y) => { return isTrue ? x : y; };

            Func<int, int> combined = x =>
            {
                var modResult = modulus(x);
                var boolResult = boolCompare(modResult);
                return conditional(boolResult, 1, 0);
            };

            //The result of these functions is that they 
            //return 1 if the original value is divisible by 5, 
            //and 0 if it is not divisible by 5.
            Console.WriteLine(combined(25)); //1
            Console.WriteLine(combined(36)); //0

            var result = conditional(boolCompare(modulus(10)), 2, 1);
            Console.WriteLine(result);

            //If this seems ridiculous, that's because it is. In the real world,
            //we would probably never do this because the corresponding line of code is
            //so easy to write and understand. However, even though this is a contrived
            //example, it also demonstrates the power of delegates because
            //we can invoke this delegate *multiple times* with different inputs,
            //whereas if we just wrote the lines of code we have to write it for
            //each possible set of inputs.
        }
    }
}
