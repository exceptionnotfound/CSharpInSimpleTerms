using System;
using System.Collections.Generic;
using System.Text;

namespace _9Polymorphism
{
    public class Animal4 { /*...*/ } //Base class

    public class Elephant2 : Animal4 //Derived class
    {
        public string ElephantType { get; set; } //African, Asian, Other?
    }

    public class Dolphin : Animal4 //Derived class
    {
        public string DolphinType { get; set; } //Bottlenose, common, other?
    }

    public static class FunWithPolymorphism
    {
        public static void OutputType(Animal4 animal)
        {
            if (animal.GetType() == typeof(Dolphin)) //GetType defined on System.Object
            {
                var dolphin = (Dolphin)animal;
                Console.WriteLine(dolphin.DolphinType);
            }
            if (animal.GetType() == typeof(Elephant2))
            {
                var elephant = (Elephant2)animal;
                Console.WriteLine(elephant.ElephantType);
            }
        }
    }
}
