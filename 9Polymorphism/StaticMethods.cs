using System;
using System.Collections.Generic;
using System.Text;

namespace _9Polymorphism
{
    public static class StaticMethods
    {
        public static string GetAnimalDetails(Animal animal) 
        {
            return animal.SpeciesName + "(AKA " + animal.CommonName + ")";
        }
    }
}
