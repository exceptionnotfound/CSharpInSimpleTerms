using System;

//NAMESPACES
//Namespaces in C# are used to organize code into different "areas".
//Think of namespaces as containers for classes, methods, and objects.

//We build specific namespaces by using the *namespace* keyword.
//Visual Studio and other IDEs will create default namespaces based on
//the name of the project. Since this project is called "11Namespaces",
//Visual Studio created the namespace _11Namespaces (in C#, a namespace
//cannot begin with a number). 

//Each of the below namespaces are defined in the OtherNamespaces.cs file.
//We specify that this current file can use objects defined in other namespaces
//by including those namespaces using the *using* keyword.

using _11Namespaces.Models.Users;
using _11Namespaces.Models.Vehicles;
using _11Namespaces.DataAccess.Repositories.Users;
using _11Namespaces.DataAccess.Repositories.Vehicles;

using N1.N2;


namespace _11Namespaces //Namespace
{
    class Program //Class Name
    {
        static void Main(string[] args) //Method Name
        {
            //NAMESPACE NESTING
            //If we want to call the class C2 (defined in NamespaceNesting.cs)
            //we can do it one of two ways.
            //Either we can use the fully-qualified namespace:
            var myVar = new N1.N2.C2();

            //or we can add a using statement to the top of the file.
            var myVar2 = new C2();

            var myVar3 = new C3();
        }
    }
}
