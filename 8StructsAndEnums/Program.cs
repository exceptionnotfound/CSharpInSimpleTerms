using System;

namespace _8StructsAndEnums
{
    class Program
    {
        

        public static void Main(string[] args)
        {
            //STRUCTS
            //All structs used in this application are defined in the Structs.cs file

            //Structure types (or structs) are small, focused collections of properties.
            //Structs are value types, and can have methods, properties, and constructors.
            //In that way, they are similar to classes.
            //However, structs cannot have a parameterless constructor, and they do not
            //support inheritance.
            
            var player = new Player();
            player.Name = "Alex Hampton";
            player.YearsPlaying = 2;

            //Because structs are value types, when they are instantiated, we must
            //give them the appropriate values for their properties.
            //We can instantiate a struct in three ways.
            //The first way is to rely on the default values of the struct's properties.

            var coach = new Coach();

            Console.WriteLine(coach.Name); //Null
            Console.WriteLine(coach.YearsCoaching); //0

            //The second way is to give each publicly-accessible property a value
            //using inline instantiation.

            var coach2 = new Coach()
            {
                Name = "John Smith",
                YearsCoaching = 12
            };

            Console.WriteLine(coach2.Name); //John Smith
            Console.WriteLine(coach2.YearsCoaching); //12

            //The third way is to create a constructor and pass values to it.

            var coach3 = new Coach3("Elaine Harkness", 6);

            Console.WriteLine(coach3.Name); //Elaine Harkness
            Console.WriteLine(coach3.YearsCoaching); //6

            //Microsoft recommends we create immutable structs, or structs that can
            //only have their property values set at instantiation.
            //We mark a struct as immutable using the keyword "readonly".
            //(See the Struct.cs file for ReadonlyPlayer struct).
            var readonlyPlayer = new ReadonlyPlayer("Matt", 1);

            //Uncomment the below line to cause a compilation error.
            //readonlyPlayer.Name = "Different Name";

            //ENUMERATIONS
            //Enumerations are integer values that have been assigned a name.
            //We typically use them to represent values and to eliminate magic numbers.
            //See the Enums.cs file for more.

            //We don't want to do this:
            var color = 1; //What does 1 mean?

            //Rather, we can impart a meaning on our variable by using an enumeration.
            var myColor = Color.Red;
            Console.WriteLine(myColor); //Red

            //We can also cast an enumeration both to and from its source type.
            myColor = Color.Blue;
            var myColorValue = (int)myColor;
            Console.WriteLine(myColorValue); //3

            var myColor2 = 4;
            var myColorEnum = (Color)myColor2;
            Console.WriteLine(myColorEnum); //Green

            //Check out the Months enum in the Enums.cs file, then come back here.

            //Bitwise flag enums can be combined using the logical OR operator (|)
            //In this way, they can represent a group of selections rather than a single option.
            Months birthdayMonths = Months.January 
                                    | Months.March 
                                    | Months.September 
                                    | Months.November;
            Console.WriteLine($"Your family has birthdays in {birthdayMonths}");

            Months otherBirthdays = Months.January
                        | Months.April
                        | Months.September;

            Console.WriteLine($"The months in both groups are {birthdayMonths & otherBirthdays}");
            //Output: The months in both groups are January, July
        }
    }
}
