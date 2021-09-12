using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathAlgorithm
{
    class AdjacencyList<T>
    {

        private int countVertices;
        public int CountVertices
        {
            get { return countVertices; }
        }
        private List<Vertex<T>> myList;
        public List<Vertex<T>> MyList
        {
            get { return myList; }
        }
        public AdjacencyList()
        {
            myList = new List<Vertex<T>>();
        }
        public void AddVertex(Vertex<T> v)
        {
            myList.Add(v);
            countVertices++;
        }
        public void AddAdge(Vertex<int> fromV, Vertex<int> toV,int weight)
        {
            //    fromV.AddEdge(toV);
            fromV.AddEdge(toV, weight);
        }
        //public void RemoveAdge(Vertex<T> fromV, Vertex<T> toV)
        //{
        //    foreach (var vertex in myList)
        //    {
        //        if (vertex == fromV)
        //        {
        //            foreach (var neighbor in vertex.Neighbors)
        //            {
        //                if (neighbor == toV)
        //                    vertex.Neighbors.Remove(neighbor);
        //            }
        //        }
        //    }
        //}
    }
}
