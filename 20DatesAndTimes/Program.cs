using System;

namespace _20DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------DateTime-----------------------------------");

            DateTime myDateTime = new DateTime(); //1 January 0001 0000 Hours (Midnight)

            DateTime fifteenthJune = new DateTime(1215, 6, 15);
            var eighteenthFebruary = new DateTime(1930, 2, 18);
            var twelfthApril = new DateTime(1945, 4, 12, 15, 35, 0);

            var now = DateTime.Now; //The date and time now
            var utcNow = DateTime.UtcNow; //The Universal Coordinated Time (UTC) value for now.
            var today = DateTime.Today; //Today's date, with a time value of midnight.

            Console.WriteLine("---------------------DateTime Manipulation-----------------------------");

            var date = DateTime.Now;
            date = date.AddHours(12);
            date = date.AddMonths(1);
            date = date.AddDays(7);
            date = date.AddMinutes(-30);

            Console.WriteLine(date);

            Console.WriteLine("--------------------Displaying Dates and Times-------------------------");

            Console.WriteLine(DateTime.Now.ToString());

            Console.WriteLine(DateTime.Now.ToString("dddd, dd MM yyyy h:mm:ss gg"));

            Console.WriteLine("--------------------Shorthand Display Methods--------------------------");

            var display = DateTime.Now.ToShortDateString();
            Console.WriteLine(display);

            var displayTime = DateTime.Now.ToShortTimeString();
            Console.WriteLine(displayTime);

            var longDisplay = DateTime.Now.ToLongDateString();
            Console.WriteLine(longDisplay);

            var longDisplayTime = DateTime.Now.ToLongTimeString();
            Console.WriteLine(longDisplayTime);

            Console.WriteLine("-------------------------Parsing a String------------------------------");

            var parsingDate = DateTime.Parse("10/24/2020 05:50AM");
            Console.WriteLine(parsingDate.ToString());

            //Try changing the string below to an unparsable date.
            DateTime parsedDate;
            bool isParsable = DateTime.TryParse("5/4/2012 11:30", out parsedDate);
            Console.WriteLine("Parsable? " + isParsable + ". Value: " + parsedDate.ToString());

            string format = "ddd MM/dd/yyyy h:mm:ss";
            parsedDate = DateTime.ParseExact("Mon 10/26/2020 9:15:45", format, null);
            Console.WriteLine(parsedDate);


            Console.WriteLine("----------------------------TimeSpan----------------------------------");

            var newTimeSpan = new TimeSpan();
            Console.WriteLine(newTimeSpan);

            //7 days, 8 hours, 10 minutes, and 35 seconds
            newTimeSpan = new TimeSpan(7, 8, 10, 35);
            Console.WriteLine(newTimeSpan); //7.08:10:35

            Console.WriteLine("----------------Math with DateTime and TimeSpan------------------------");

            DateTime startDate = new DateTime(2020, 11, 10, 9, 35, 0);
            DateTime endDate = new DateTime(2020, 11, 14, 15, 10, 20);

            TimeSpan duration = endDate - startDate;
            Console.WriteLine(duration); //4.05:35:20

            duration = new TimeSpan(15, 45, 30); //15 hours, 45 minutes, 30 seconds

            DateTime initialDate = DateTime.Now;
            var newDate = initialDate.Add(duration);
            Console.WriteLine(newDate);

            newDate = newDate.Subtract(duration);
            Console.WriteLine(newDate); //Should be now

            TimeSpan negative = new TimeSpan(-4, 30, 12);
            Console.WriteLine(negative);
            Console.WriteLine(negative.Duration()); //Positive value
            Console.WriteLine(negative.Negate()); //Positive value; negating a negative value results in a positive value.

            Console.WriteLine("--------------------------TimeZoneInfo--------------------------------");

            TimeZoneInfo mountainStandard = TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time");
            Console.WriteLine(mountainStandard);

            var allTimeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach(var timeZone in allTimeZones)
            {
                //Uncomment the below line to output all time zones on this machine.
                //Console.WriteLine(timeZone);
            }
        }
    }
}
