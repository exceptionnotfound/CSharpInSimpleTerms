using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _22Iterators
{
    //We're going to create a generic type that combines functionality
    //from the Stack<T> and Queue<T> types we learned about in 
    //Part 13 Arrays and Collections.
    //This class will have the behaviors of both Stack<T> and Queue<T>.
    public class StackQueue<T> : IEnumerable<T>
    {
        //First, we need a generic List<T> to store the elements in this StackQueue
        private List<T> elements = new List<T>();

        //We also need a variable that keeps track of the number of elements.
        private int _top = 0;

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
            Console.WriteLine("Queueing " + item.ToString());
            elements.Insert(elements.Count, item);
            _top++; //Increment the counter because we added an element
        }

        //Insert at "front of line" or top of list
        public void Push(T item)
        {
            Console.WriteLine("Pushing " + item.ToString());
            elements.Insert(0, item);
            _top++;//Increment the counter because we added an element
        }

        //The method Pop uses T as its return type.

        //Remove the element at the top of the list
        public T Pop()
        {
            var element = elements[0];
            Console.WriteLine("Popping " + element.ToString());
            elements.RemoveAt(0);
            _top--; //Decrement the counter because we removed an element
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //We will yield return the elements from first to last.
            for(int index = 0; index < _top; index++)
            {
                yield return elements[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //At this point, go back to Program.cs to continue.
    }
}
