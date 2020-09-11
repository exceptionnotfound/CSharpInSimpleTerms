using System;

namespace _4Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPERATORS

            //Operators in C# are often symbols or groups of symbols
            //that operate on one or more values.

            int total = 5 * 5; //This line has two operators;
                               //the * (multiplication) operator 
                               //which takes 5 and 5 as inputs
                               //and the = (assignment) operator 
                               //which assigns the result of 5*5 to the variable total

            //ASSIGNMENT AND EQUALITY OPERATORS 

            //ASSIGNMENT (=)

            //The assignment operator = assigns a value to a variable, property, etc.
            int year = 2020;
            Console.WriteLine(year); //2020

            //Unlike other operators, the assignment operator is right-associative
            int year1; 
            int year2; 
            int year3 = 2020;

            year1 = year2 = year3; //Will be evaluated as year1 = (year2 = year3)

            //EQUALITY (==)

            //The equality operator == returns a boolean value stating whether or not
            //two values are equal.
            int five = 5;
            int otherFive = 5;

            bool areEqual = five == otherFive;

            Console.WriteLine(areEqual);

            //Note that, for reference types, the equality operator == only
            //returns true if the two reference types are pointing
            //at the same object.
            var myClass = new MyClass();
            var myOtherClass = new MyClass();
            var myThirdClass = myClass;

            Console.WriteLine(myClass == myOtherClass); //false
            Console.WriteLine(myOtherClass == myThirdClass); //true

            //INEQUALITY (!=)

            //We can check if two values are not equal using the inequality operator !=
            var myMoney = 6.54M;
            var theirMoney = 4.65M;

            Console.WriteLine(myMoney != theirMoney); //true

            //INCREMENT ASSIGNMENT (+=) AND DECREMENT ASSIGNMENT (-=)

            //When working with number types, we can increment or decrement
            //their value using the increment assignment operators += and -=
            var i = 16;
            i += 5; 
            Console.WriteLine(i); //21

            var j = 61;
            j -= 15; 
            Console.WriteLine(j); //46

            //NULL-COALESCING ASSIGNMENT (??=)

            //There's also the null-coalescing assignment operator ??=, which assigns
            //the value to the left-hand operand if and only if the left-hand operand is null
            int? startNum = 5;
            startNum ??= 3; //startNum is 5
            Console.WriteLine(startNum);

            startNum = null;
            startNum ??= 3; //startNum is 3
            Console.WriteLine(startNum);

            //MATH OPERATORS

            //BASIC MATH
            //ADDITION (+)
            //SUBTRACTION (-)
            //MULTIPLICATION (*)
            //DIVISION (/)

            //The basic math operators +, -, *, / perform simple math operations
            var sum = 5 + 9; //14
            var difference = 56 - 14; //42
            var product = 6 * 6; //36
            var quotient = 42 / 7; //6

            Console.WriteLine(sum + ", " + difference + ", " + product + ", " + quotient);

            //REMAINDER (%)

            //The remainder operator % (AKA modulus) will output 
            //the remainder from a division operation.
            var modulus = 43 % 5; //3
            Console.WriteLine(modulus);

            //INCREMENT (++) AND DECREMENT (--)
            //The increment ++ and decrement -- operators change the value of
            //a numeric object by 1.
            var value = 3;
            value++;
            Console.WriteLine(value); //4
            value--;
            Console.WriteLine(value--); //3

            //Postfixed increment operators show the value *before* the operation occurs
            value = 3;

            Console.WriteLine(value); //3
            Console.WriteLine(value++); //3
            Console.WriteLine(value); //4

            //Prefixed increment operators show the value *after* the operation occurs
            value = 3;

            Console.WriteLine(value); //3
            Console.WriteLine(++value); //4
            Console.WriteLine(value); //4

            //ORDER OF OPERATIONS
            //Math operators follow an order of operations. 
            //First, increment and decrement
            //Then, multiple, divide, or remainder
            //Then addition or subtraction

            var output = 5 + 2 * 9; //Evaluated as 5 + (2 * 9) = 19
            Console.WriteLine(output);
            var output2 = (5 + 2) * 9; //63
            Console.WriteLine(output2);

            var output3 = 15 / 5 * 3; //Evaluated as (15 / 5) * 3 = 9
            Console.WriteLine(output3);
            var output4 = 15 / (5 * 3); //1
            Console.WriteLine(output4);

            //BOOLEAN LOGIC OPERATORS
            //When dealing with boolean values, we use a set of operators
            //design to work on boolean logic.

            //Negation (!)
            var isTrue = true;
            Console.WriteLine(!isTrue); //false

            var isFalse = false;
            if (!isFalse)
            {
                Console.WriteLine("The expression is false!");
            }

            //Conditional Logical AND (&&)
            //AND operations return TRUE if both operands are TRUE; otherwise, they return FALSE
            //The conditional logical AND will evaluate the first operand; if it is FALSE, it returns FALSE
            //WITHOUT evaluating the second operand.
            var hasName = true;
            var hasAddress = true;

            var isValidCustomer = hasName && hasAddress; //true
            Console.WriteLine(isValidCustomer);

            hasName = false;
            var isStillValidCustomer = hasName && hasAddress; //false
            Console.WriteLine(isStillValidCustomer);

            //Conditional Logical OR (||)
            //Logical OR operations return TRUE if one or more of the operands is TRUE.
            //If all operands are FALSE, logical OR will return FALSE.
            var hasPhone = false;
            var hasEmail = true;

            var hasValidContactInfo = hasPhone && hasEmail; //true
            Console.WriteLine(hasValidContactInfo);
            var areYouSure = hasEmail && hasPhone; //true, hasPhone not evaluated
            Console.WriteLine(areYouSure);

            //Logical AND (&)
            //This operator will always evaluate both operands.
            var hasLastName = true;
            var hasFirstName = false;

            var hasCompleteName = hasFirstName & hasLastName; //false
            Console.WriteLine(hasCompleteName);

            //Logical OR (|)
            //This operator will always evaluate both operands.
            hasLastName = true;
            hasFirstName = false;

            var hasAnyName = hasFirstName | hasLastName; //true

            //Logical Exclusive OR (^)
            //An exclusive-OR operation returns true if and only if one operand is true and one operand is false.
            //If both operands are true or both operands are false, exclusive-OR returns false.
            var isXOR = true ^ true; //false
            Console.WriteLine(isXOR);
            isXOR = true ^ false; //true
            Console.WriteLine(isXOR);
            isXOR = false ^ true; //true
            Console.WriteLine(isXOR);
            isXOR = false ^ false; //false
            Console.WriteLine(isXOR);

            //Boolean logic operators execute in this order: !, &, ^, |, &&, ||
            var isTest = true ^ false & true; //Same as true ^ (false & true), result true
            Console.WriteLine(isTest);
            var isOtherTest = false || (false ^ true && true); //true
            Console.WriteLine(isOtherTest);

            //COMPARISON OPERATORS 
            //Less Than (<) and Less Than Or Equal To (<=)
            bool isLessThan = 7 < 9; //true
            Console.WriteLine(isLessThan);
            isLessThan = 9 < 7; //false
            Console.WriteLine(isLessThan);

            int otherValue = 6;
            otherValue++;
            bool isLessThanOrEqual = otherValue <= 7; //true
            Console.WriteLine(isLessThanOrEqual);

            //Greater Than (>) and Greater Than Or Equal (>=)
            bool isGreaterThan = 18 > 15; //true
            Console.WriteLine(isGreaterThan);
            isGreaterThan = -7 > -10; //true
            Console.WriteLine(isGreaterThan);

            int testValue = 88;
            bool isLarge = testValue >= 50; //true
            Console.WriteLine(isLarge);

            //CONDITIONAL OPERATOR (?:)
            //The conditional operator ?: returns one of two values based on
            //whether a given expression is true or false.
            isTrue = true;
            string message = isTrue ? "Yay!" : "Boo..."; //message is "Yay!"
            Console.WriteLine(message);

            isFalse = false;
            message = isFalse ? "Yay!" : "Boo..."; //message is "Boo..."
            Console.WriteLine(message);

            //It is possible to combine this operator multiple times with itself,
            //though this often results in hard-to-read code.
            hasName = false;
            hasAddress = false;
            hasPhone = true;

            message = hasName ? "Welcome!" :
                          hasAddress ? "Hiya!" :
                          hasPhone ? "Thanks for calling!" : "Whoops.";

            Console.WriteLine(message); //"Thanks for calling!"

            //NULL-COALESCING OPERATOR (??)
            //The null coalescing operator ??  returns the value of the 
            //left-hand operand if that value is not null; otherwise, 
            //it evaluates the right-hand operand and returns that.

            int? val = null;
            int counter = val ?? 1; //counter is 1
            Console.WriteLine(counter);

            int? otherVal = 5;
            counter = otherVal ?? 1; //counter is 5
            Console.WriteLine(counter);
        }
    }
}
