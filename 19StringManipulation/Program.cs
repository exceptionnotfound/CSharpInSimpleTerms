using System;
using System.Globalization;
using System.Text;

namespace _19StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------CULTURES-----------------------");
            Console.Write("Please enter a culture code:");
            string cultureCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cultureCode))
                cultureCode = "en-US";

            Console.WriteLine("-------------Creating a Culture Object----------------");
            CultureInfo myCulture = new CultureInfo(cultureCode);

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString(myCulture.DateTimeFormat) + " (" + myCulture.Name + ")");

            Console.WriteLine("-----------------Invariant Culture--------------------");

            //Invariant Culture
            var invariantCulture = CultureInfo.InvariantCulture;
            //Will output in the MM/dd/yyyy 24-hour clock format
            Console.WriteLine(now.ToString(invariantCulture.DateTimeFormat));

            Console.WriteLine("-----------------ESCAPE CHARACTERS--------------------");

            string withNewline = "This is on the first line.\nThis is on the second.";
            Console.WriteLine(withNewline);

            string dialogue = "She said, \"I didn't know that was him!\".";
            Console.WriteLine(dialogue);


            Console.WriteLine("---------------------OPERATORS------------------------");

            Console.WriteLine("--------------Interpolated Strings ($)----------------");

            string name1 = "Jack";
            string name2 = "Quint";

            Console.WriteLine($"Good morning {name1} and {name2}!");

            Console.WriteLine("-----------------Literal Strings (@)------------------");
            string filePath = @"C:\this\is\a\file\path";
            Console.WriteLine(filePath);

            Console.WriteLine("---------------------FORMATTING-----------------------");

            decimal money = 5.67M;
            Console.WriteLine(money.ToString("C"));

            double percentage = 0.67;
            Console.WriteLine(percentage.ToString("P"));

            Console.WriteLine("-------------------Custom Formats---------------------");

            int phoneNumber = 2125559731;
            string format = "(###) ###-####";
            Console.WriteLine(phoneNumber.ToString(format));

            Console.WriteLine("-------------------CONCATENATION----------------------");

            Console.WriteLine("----------------Naive Concatenation-------------------");

            int value = 6;

            Console.WriteLine("The value is " + value.ToString());

            Console.WriteLine("------------------String.Concat()---------------------");

            string hello = "Hello ";
            string firstName1 = "Jack, ";
            string firstName2 = "Quint, ";
            string firstName3 = "June, ";
            string firstName4 = "and Dirk!";

            var combined = string.Concat(hello, firstName1, firstName2, firstName3, firstName4);
            Console.WriteLine(combined);

            Console.WriteLine("-------------------StringBuilder---------------------");
            StringBuilder builder = new StringBuilder();

            for(int i = 0; i < 100; i++)
            {
                builder.Append(i);
                builder.Append(" ");
            }

            Console.WriteLine(builder.ToString());

            Console.WriteLine("---------------SEARCHING IN STRINGS-----------------");

            Console.WriteLine("--------------------Contains()----------------------");

            string sentence = "This is a sentence.";

            Console.WriteLine(sentence.Contains("is a")); //true
            Console.WriteLine(sentence.Contains("isa")); //false

            Console.WriteLine("--------------------IndexOf()-----------------------");

            int index = sentence.IndexOf("is");
            Console.WriteLine($"Found the substring 'is' at position {index}");

            Console.WriteLine("-----------StartsWith() and EndsWith()--------------");

            bool startsWith = sentence.StartsWith("This"); //true
            bool endsWith = sentence.EndsWith("tence"); //false, missing the period

            Console.WriteLine(startsWith);
            Console.WriteLine(endsWith);

            Console.WriteLine("---------------STRING MANIPULATION------------------");

            Console.WriteLine("---------------------Trim()-------------------------");
            
            string sentenceWhitespace = "     This has some whitespace.     ";
            Console.WriteLine(sentenceWhitespace.TrimStart() + "End of line.");
            Console.WriteLine(sentenceWhitespace.TrimEnd() + "End of line.");
            Console.WriteLine(sentenceWhitespace.Trim() + "End of line."); //Trims whitespace at both beginning and end

            Console.WriteLine("---------------------Padding------------------------");

            string sevenDigitPhone = "1234567";

            Console.WriteLine(sevenDigitPhone.PadLeft(10, '0'));
            Console.WriteLine(sevenDigitPhone.PadRight(10, '0'));

            Console.WriteLine("-------------------Change Case----------------------");

            string mixedCaseString = "ThIs Is A mIxEd cAsE StRiNg.";

            Console.WriteLine(mixedCaseString.ToUpper());
            Console.WriteLine(mixedCaseString.ToLower());

            Console.WriteLine("-------------------COMPARISON-----------------------");

            string test1 = "This is a semicolon ;";
            string test2 = "This is a semicolon ;";
            string test3 = "This is a semicolon ;"; //Actually it's a greek question mark.

            Console.WriteLine($"test1 and test2 are {(test1 == test2 ? "equal" : "NOT equal")}");
            Console.WriteLine($"test2 and test3 are {(test2 == test3 ? "equal" : "NOT equal")}");

            string firstString = "This is the First String.";
            string secondString = "This Is The First String.";

            Console.WriteLine(firstString.Equals(secondString)); //False
            Console.WriteLine(firstString.Equals(secondString, StringComparison.OrdinalIgnoreCase)); //True
            Console.WriteLine(firstString.Equals(secondString, StringComparison.InvariantCultureIgnoreCase)); //True
            Console.WriteLine(firstString.Equals(secondString, StringComparison.InvariantCulture)); //False


            Console.WriteLine("----------------SPLITTING STRINGS--------------------");

            string toBeSplit = "This is a bunch of words and we will split this sentence.";

            var words = toBeSplit.Split(' ');

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }


            Console.WriteLine("--------------Splitting by Multiple------------------");

            string toParse = "This:is another\tstrange/sentence.";

            char[] delimiters = { ':', ' ', '\t', '/' };

            words = toParse.Split(delimiters);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("--------------Splitting by Strings------------------");

            string toSplit = "This...is our final>>odd sentence.";

            string[] stringDelimiters = { ">>", "..." };

            words = toSplit.Split(stringDelimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
