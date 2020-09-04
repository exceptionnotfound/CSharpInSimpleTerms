using System;
using System.Collections.Generic;
using System.Text;

namespace _5BasicStatementsAndLoops
{
    public static class Email
    {
        public static string GetEmail()
        {
            var emails = new List<string>
            {
                "myfriend@email.com",
                "myenemy@email.com",
                "mybeloved@email.com",
                "myacquaintance@email.com"
            };

            foreach (var email in emails)
            {
                if (email == "mybeloved@email.com")
                {
                    return email; //Loop stops executing
                }
            }

            return "";
        }
    }
}
