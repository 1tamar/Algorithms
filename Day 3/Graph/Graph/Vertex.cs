using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Vertex<T>
    {
        public int FarFromBase = -1;
        public Vertex<int> parent;
        public T Value { get; }   // can be made writable
        public List<Vertex<T>> Neighbors { get; }
        public bool IsVisited { get; set; }
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
