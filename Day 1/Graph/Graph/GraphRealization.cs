using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class GraphRealization<T>
    {

        public GraphRealization(params Vertex<T>[] initialNodes)
            : this((IEnumerable<Vertex<T>>)initialNodes) { }

        public GraphRealization(IEnumerable<Vertex<T>> initialNodes = null)
        {
            Vertices = initialNodes?.ToList() ?? new List<Vertex<T>>();
        }

        public List<Vertex<T>> Vertices { get; }

        public int Size => Vertices.Count;

        public void AddPair(Vertex<T> first, Vertex<T> second)
        {
            AddToList(first);
            AddToList(second);
            AddNeighbors(first, second);
        }

        public void DepthFirstSearch(Vertex<T> root, Action<string> writer)
        {
            UnvisitAll();
            DepthFirstSearchImplementation(root, writer);

        }

        private void DepthFirstSearchImplementation(Vertex<T> root, Action<string> writer)
        {
            if (!root.IsVisited)
            {
                writer($"{root.Value} ");
                root.IsVisited = true;

                foreach (Vertex<T> neighbor in root.Neighbors)
                {
                    DepthFirstSearchImplementation(neighbor, writer);
                }
            }
        }

        private void AddToList(Vertex<T> Vertex)
        {
            if (!Vertices.Contains(Vertex))
            {
                Vertices.Add(Vertex);
            }
        }

        private void AddNeighbors(Vertex<T> first, Vertex<T> second)
        {
            AddNeighbor(first, second);
            AddNeighbor(second, first);
        }

        private void AddNeighbor(Vertex<T> first, Vertex<T> second)
        {
            if (!first.Neighbors.Contains(second))
            {
                first.AddEdge(second);
            }
        }

        private void UnvisitAll()
        {
            foreach (var Vertex in Vertices)
            {
                Vertex.IsVisited = false;
            }
        }

    }
}
