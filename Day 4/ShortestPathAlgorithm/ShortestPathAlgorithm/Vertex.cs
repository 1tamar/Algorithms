using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathAlgorithm
{
    class Vertex<T>
    {
        //   public Vertex<T> parent = null;
        //   public bool IsVisited = false;
        public T Value { get; }
        public List<Vertex<T>> Neighbors { get; }
        public List<Edge<T>> NeighbotsWithweight;
        public Vertex(T value, IEnumerable<Vertex<T>> neighbors = null)
        {
            Value = value;
            NeighbotsWithweight = new List<Edge<T>>();
            Neighbors = neighbors?.ToList() ?? new List<Vertex<T>>();
            //         IsVisited = false;
        }
        public void AddEdge(Vertex<T> vertex, int weight)
        {
            Neighbors.Add(vertex);
            vertex.Neighbors.Add(this);
            Edge<T> fromThis = new Edge<T>(weight, this, vertex);
            Edge<T> toThis = new Edge<T>(weight, vertex, this);

            this.NeighbotsWithweight.Add(fromThis);
            vertex.NeighbotsWithweight.Add(toThis);
        }
        public void RemoveEdge(Vertex<T> Vertex)
        {
            //         Neighbors.Remove(Vertex);
        }
    }
}
