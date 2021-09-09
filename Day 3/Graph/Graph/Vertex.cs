using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    //enum status { snake=1,roddle,regular};

    class Vertex<T>
    {
        public int FarFromPrevious = -1;
        public int FarFromBase = -1;
        public Vertex<int> parent=null;
        public bool IsVisited = false;
        // public status status;
        public int howManyThrow = -1;
        public T Value { get; }   // can be made writable
        public List<Vertex<T>> Neighbors { get; }
        public Vertex(T value, IEnumerable<Vertex<T>> neighbors = null)
        {
            Value = value;
            Neighbors = neighbors?.ToList() ?? new List<Vertex<T>>();
            IsVisited = false;
        }
        public void AddEdge(Vertex<T> Vertex)
        {
            Neighbors.Add(Vertex);
        }
        public void RemoveEdge(Vertex<T> Vertex)
        {
            Neighbors.Remove(Vertex);
        }
    }
}
