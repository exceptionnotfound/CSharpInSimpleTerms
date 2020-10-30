using System;
using System.Collections.Generic;
using System.Text;

namespace _21Indexers
{
    //We can implement an indexer on an interface using
    //a slightly different syntax.
    public interface IHasIndexer
    {
        string this[int index]
        {
            get;
            set;
        }
    }

    //Classes which implement that interface must provide
    //the implementation for that indexer.
    public class HasIndexer : IHasIndexer
    {
        private string[] _values = new string[10];

        public string this[int index]
        {
            get => _values[index];
            set => _values[index] = value;
        }
    }
}
