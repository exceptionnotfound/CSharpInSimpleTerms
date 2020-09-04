using System;
using System.Collections.Generic;
using System.Text;

namespace _6Methods
{
    public class Methods
    {
        //A *method* in C# is a block of code that will be executed when
        //some other code calls, or *invokes*, it. 

        //A method has five parts:
        //1. An access modifier (public, private, etc.)
        //2. A return type
        //3. A name
        //4. An optional set of parameters
        //5. A collection of code statements bounded by curly braces { }
        public string GetHello(string name)
        {
            return "Hello " + name + "!";
        }

        //In the above method:
        //1. "public" is the access modifier
        //2. "string" is the return type
        //3. "GetHello" is the name
        //4. "string name" is a parameter
        //5. Everything between the { and } will be executed when the method is invoked.

        //VOID METHODS
        //Methods can also use the special return type *void*, which tells the C# compiler
        //that this method will not return anything.
        public void DoSomething() 
        {
            Console.WriteLine("DoSomething was invoked!");
        }

        //If our method has a return type but does not use the "return" keyword
        //we will get a compilation error.
        //Uncomment the below method to see this.
        //public string GetGoodbye()
        //{
        //    string goodbye = "Goodbye!";
        //}

        //Similarly, if our method has a void return type but uses the "return" keyword
        //we will also get a compilation error.
        //Uncomment the below method to see this.
        //public void DoSomething2()
        //{
        //    return "Something!";
        //}

        //Now go to the Parameters.cs class for the next part of the lesson.
    }
}
