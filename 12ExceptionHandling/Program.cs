using System;

namespace _12ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXCEPTIONS
            //In C#, an "exception" is an error encountered while the program is running.
            //All exceptions inherit from System.Exception
            //When an exception happens, we say it is "thrown" by the program.

            //C# includes a huge variety of built-in exceptions.
            //For example, if we attempt to divide by zero, we will get a DivideByZeroException thrown.
            int zero = 0;
            int two = 2;

            //Uncomment the below line to see the exception thrown.
            //int result = two / zero; //Throws System.DivideByZeroException

            //UNDERSTANDING EXCEPTIONS
            //Let's create a new instance of System.Exception
            var myException = new Exception();

            //C# populates exceptions, when they are thrown, with a bunch of useful information.
            //For example, the error message...
            var errorMessage = myException.Message;

            //...the stack trace...
            var stackTrace = myException.StackTrace;

            //...and any inner exceptions that might exist.
            var innerException = myException.InnerException;

            //We use these properties to debug the exception and fix the code that threw it.

            //HANDLING THROWN EXCEPTIONS
            //When we have a code block that we think might throw an exception,
            //we can handle it by wrapping that code in a *try* block.
            //We can also use a *catch* block to process any thrown exceptions.

            //Execution of code in a try block stops when an exception is encountered.
            //Therefore, CallOtherMethod() in the below try block will never be invoked, 
            //because an exception is always thrown before that line.
            try
            {
                var result = two / zero; //Will throw DivideByZeroException

                CallOtherMethod(); //Never invoked
            }
            catch (Exception ex)
            {
                //Code that will "handle" the exception.
            }

            //Much of the time, we will "handle" an exception by logging it.
            try
            {
                var result = two / zero; //Will throw DivideByZeroException
            }
            catch (Exception ex)
            {
                var errorLogger = new MyErrorLogger();
                errorLogger.Log(ex);
            }

            //Choosing to do nothing with a thrown exception is called "swallowing"
            //the exception, and is considered bad practice.
            try
            {
                var result = two / zero; //Will throw DivideByZeroException
            }
            catch (Exception ex)
            {
                //Swallowing exceptions is a bad practice!
            }

            //However, that doesn't mean we never do this. We just need to do it with
            //full knowledge of the potential problems.

            //MULTIPLE CATCHES
            //We can use multiple *catch* statements to catch specific exceptions.
            //The most-specific exceptions are listed first, and the least-specific are listed last.
            try
            {
                //Code that might throw an exception
            }
            catch (DivideByZeroException ex)
            {
                //Handle the divide by zero situation
            }
            catch (ArgumentException ex)
            {
                //Handle the argument exception situation
            }
            catch (Exception ex)
            {
                //Handle all other exceptions
            }

            //FINALLY BLOCKS
            //In addition to *try* blocks and *catch* blocks, C# also allows us to have
            //a *finally* block. Code in this block is executed whether or not an
            //exception is thrown.

            try
            {
                //Code that might throw an exception.
            }
            catch
            {
                //Code that is only executed if an exception is thrown.
            }
            finally
            {
                //Code that is executed whether or not an exception is thrown.
            }

            //We often use finally blocks when we are accessing external resources
            //such as files or databases.
            System.IO.FileStream file = null;
            System.IO.FileInfo fileInfo = null;

            try
            {
                //Note that unless this path points at a valid file, this
                //line will throw an exception.
                fileInfo = new System.IO.FileInfo("C:\\path\\to\\file.txt");

                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            catch (Exception e)
            {
                //Handle the exception
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close(); //Close the file stream
                }
            }

            //THROWING EXCEPTIONS
            //We can manually throw exceptions using the *throw* keyword.
            bool someCondition = true;
            if (someCondition)
            {
                //Normal condition
            }
            else //Error Condition
            {
                throw new Exception("Exception message goes here!");
            }

            //We commonly do this in situations where the program is in an error state,
            //and we need to stop processing before the situation gets worse.
            //Check out the MyErrorLogger.cs class for another common example.

            //CUSTOM EXCEPTIONS
            //We can also create custom exception classes. Check out the CustomException.cs file
            //for more.

            //When we want to throw a custom exception, we do that exactly like all other exceptions.

            //Uncomment the below line to see this in action.
            //throw new CustomException("This is a custom exception message.");

            //RE-THROWING EXCEPTIONS
            //There are occasions when we want to throw an exception that has already been
            //caught in a *catch* block. 
            //There are two ways to do this. The first is to simply use the *throw* keyword
            //in the catch block. Doing this preserves the original stack trace so it
            //can be inspected later.
            try
            {
                //Code that might throw an exception
            }
            catch (Exception ex)
            {
                //Handle the exception
                throw;
            }

            //We can also re-throw the exception variable. However, doing this erases the
            //stack trace. Therefore this is considered bad practice.
            try
            {
                //Code that might throw an exception
            }
            catch (Exception ex)
            {
                //Handle the exception
                throw ex; //This is different!
            }
        }

        public static void CallOtherMethod() { /*...*/ }
    }
}
