using System;
using System.Collections.Generic;
using System.Text;

namespace _15Generics
{
    //CONSTRAINTS

    //It is possible to tell the C# compiler to only allow certain types
    //in a generic class or method. For example, we might restrict our
    //StackQueue class to only use reference types:

    public class StackQueueReferenceTypes<T> where T : class { /*...*/ }

    //If we try to create an instance of this class with a non-reference type
    //(e.g. int, long, double, etc.) we will get an error.

    //WHY USE CONSTRAINTS?

    //Constraints are about expectations. When a custom class is created, there may be
    //an implicit expectation that the class is only used for a certain kind of type.
    //Constraints take these implicit expectations and make them explicit, and it becomes
    //easier to tell when a constraint is being violated because that causes a build error.

    //KINDS OF CONSTRAINTS

    //SPECIFIC TYPE
    //We can constrain a generic to only use a specific type

    public class StackQueueSpecificType<T> where T : OtherClass { /*...*/ }

    //Note that, due to inheritance and polymorphism (see Part 9) any class which inherits 
    //from OtherClass will also be usable in this instance.

    //SPECIFIC INTERFACE
    //We can constrain a generic to only use types that implement
    //a specific interface.

    public class StackQueueSpecificInterface<T> where T : IOtherInterface { /*...*/ }

    //PUBLIC PARAMETERLESS CONSTRUCTOR
    //We can constrain a generic to only use types that have a
    //public parameterless constructor.

    public class StackQueuePublicParameterless<T> where T : new() { /*...*/ }

    //NULLABLES
    public class StackQueueNullable<T> where T : class? { /*...*/ } //Will accept 
                                                                    //a class or null
}
