using System;
using System.Collections.Generic;
using System.Text;

namespace _12ExceptionHandling
{
    public class MyErrorLogger
    {
        public void Log(Exception ex)
        {
            //We might log the exception to a database or another datastore.
            //We might also return a friendly error message to display to the user,
            //or some other action.
        }


        //A common scenario for throwing an exception manually is when
        //a method has been defined but has no implementation yet.
        public void Log(Exception ex, string customMessage)
        {
            throw new NotImplementedException();
        }
    }
}
