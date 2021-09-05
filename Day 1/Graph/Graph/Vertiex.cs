using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Vertex<T>
    {
        //private List<Vertex<T>> neighbors;
        //private T value;
        //public void SetValue(T value)
        //{
        //    this.value = value;
        //}
        //public T GetValue()
        //{
        //    return this.value;
        //}
        //public void SetNeighbors(List<Vertex<T>> neighbors)
        //{
        //    this.neighbors = neighbors;
        //}
        //public List<Vertex<T>> GetNeighbors()
        //{
        //    return this.neighbors;
        //}

        public Vertex(T value, params Vertex<T>[] parameters)
     : this(value, (IEnumerable<Vertex<T>>)parameters) { }

        public Vertex(T value, IEnumerable<Vertex<T>> neighbors = null)
        {
            Value = value;
            Neighbors = neighbors?.ToList() ?? new List<Vertex<T>>();
            IsVisited = false;  // can be omitted, default is false but some
                                // people like to have everything explicitly
                                // initialized
        }

        public T Value { get; }   // can be made writable

        public List<Vertex<T>> Neighbors { get; }

        public bool IsVisited { get; set; }

        public int NeighborCount => Neighbors.Count;

        public void AddEdge(Vertex<T> Vertex)
        {
            Neighbors.Add(Vertex);
        }

        public void AddEdges(params Vertex<T>[] newNeighbors)
        {
            Neighbors.AddRange(newNeighbors);
        }

        public void AddEdges(IEnumerable<Vertex<T>> newNeighbors)
        {
            Neighbors.AddRange(newNeighbors);
        }

        public void RemoveEdge(Vertex<T> Vertex)
        {
            Neighbors.Remove(Vertex);
        }

        public override string ToString()
        {
            return Neighbors.Aggregate(new StringBuilder($"{Value}: "), (sb, n) => sb.Append($"{n.Value} ")).ToString();
            //return $"{Value}: {(string.Join(" ", Neighbors.Select(n => n.Value)))}";
        }
    }
}
