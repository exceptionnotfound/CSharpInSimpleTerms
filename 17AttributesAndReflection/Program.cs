using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _17AttributesAndReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Attributes------------------------");

            var bookType = typeof(DonQuixote);
            var attributeType = typeof(AuthorInformationAttribute);

            var attribute = (AuthorInformationAttribute)Attribute.GetCustomAttribute(bookType, attributeType);

            Console.WriteLine("Published by " + attribute.AuthorName + " in " + attribute.YearPublished);


            Console.WriteLine("---------------------Reflection------------------------");

            //Reflection is a technique that allows us to get information *about* an element,
            //rather than the element itself.

            //The most basic form of reflection is the GetType() method.
            int myInt = 5;
            Type type = myInt.GetType();
            Console.WriteLine(type);

            //We can also get information about entire assemblies...
            Assembly assembly = typeof(DateTime).Assembly;
            Console.WriteLine(assembly);

            Assembly bookAssembly = typeof(OneThousandAndOneNights).Assembly;
            Console.WriteLine(bookAssembly);


            //...or custom classes and their members.
            ReflectedClass reflected = new ReflectedClass();
            MemberInfo member = reflected.GetType().GetMethod("Add");
            Console.WriteLine(member);

            PropertyInfo property = reflected.GetType().GetProperty("Property1");
            Console.WriteLine(property);

            ConstructorInfo constructor = reflected.GetType().GetConstructor(new Type[0]);
            Console.WriteLine(constructor);

            Console.WriteLine("---------Creating an Instance with Reflection---------");

            //We can use reflection to create instances of objects where we only know the type.
            //First, let's get the type of an object.
            ReflectedClass newReflected = new ReflectedClass();

            var reflectedType = newReflected.GetType();

            //We can use that type to create a new instance using the Activator class.
            object newObject = Activator.CreateInstance(reflectedType);
            Console.WriteLine(newObject); //_17AttributesAndReflection.ReflectedClass

            Console.WriteLine("------------Reflection and Generics-------------");

            //We can use properties on the Type type to determine if a type is a generic.
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(numbers.GetType().IsGenericType); //True

            //We can also get the entire type definition, generic parameters included.
            Console.WriteLine(numbers.GetType().GetGenericTypeDefinition());

            //To instantiate a generic object with reflection takes a bit more work.
            Type d = numbers.GetType().GetGenericTypeDefinition();

            //We need the type of the generic parameters in an array
            Type[] typeArgs = new Type[] { typeof(int) };
            Type constructed = d.MakeGenericType(typeArgs);

            //We use Activator to create an instance.
            object list = Activator.CreateInstance(constructed);

            Console.WriteLine(list.GetType());
        }
    }
}
