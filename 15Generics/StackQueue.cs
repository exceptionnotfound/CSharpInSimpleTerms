using System;
using System.Collections.Generic;
using System.Text;

namespace _15Generics
{
    //We're going to create a generic type that combines functionality
    //from the Stack<T> and Queue<T> types we learned about in 
    //Part 13 Arrays and Collections.
    //This class will have the behaviors of both Stack<T> and Queue<T>.
    public class StackQueue<T>
    {
        //First, we need a generic List<T> to store the elements in this StackQueue
        private List<T> elements = new List<T>();

        //A Queue has methods Enqueue() and Dequeue()
        //A Stack has methods Push() and Pop()
        //It works out that Dequeue() and Pop() are the same method; they both
        //remove the element at the top of the collection.
        //Therefore we don't need to implement both of those methods.

        //For the Enqueue and Push methods, the placeholder T is used
        //as a parameter to the methods. This specifies that we can pass
        //arguments of type T to these methods.

        //Insert at "back of line" or bottom of list
        public void Enqueue(T item)
        {
            elements.Insert(elements.Count, item);
        }

        //Insert at "front of line" or top of list
        public void Push(T item)
        {
            elements.Insert(0, item);
        }

        //The method Pop uses T as its return type.

        //Remove the element at the top of the list
        public T Pop()
        {
            var element = elements[0];
            elements.RemoveAt(0);
            return element;
        }

        //At this point, go back to Program.cs to continue this part.
    }
}
