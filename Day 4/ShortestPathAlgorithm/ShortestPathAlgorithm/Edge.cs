using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathAlgorithm
{
    class Edge<T>
    {
        public int weight;
        public Vertex<T> from;
        public Vertex<T> to;
        public Edge(int weight,Vertex<T> from, Vertex<T>to)
        {
            this.weight = weight;
            this.from = from;
            this.to = to;
        }
    }
}
