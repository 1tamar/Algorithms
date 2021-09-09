using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class AdjacencyList<T>
    {
        private int countVertices;
        public int CountVertices
        {
            get { return countVertices; }
        }

        private List<List<Vertex<T>>> myList;
        public List<List<Vertex<T>>> MyList
        {
            get { return myList; }
        }

        public AdjacencyList(/*int countVertices*/)
        {
            myList = new List<List<Vertex<T>>>();
        }
        public void AddVertex(Vertex<T> v)
        {
            List<Vertex<T>> newList = new List<Vertex<T>>();
            newList.Add(v);
            myList.Add(newList);
            countVertices++;
        }
        public void AddAdge(int fromV,int toV)
        {
            myList[fromV].Add(MyList[toV][0]);
        }
        public void RemoveAdge(Vertex<T> fromV, Vertex<T> toV)
        {
            foreach (var list in myList)
            {
                if (list[0] == fromV)
                {
                    foreach (var vertex in list)
                    {
                        if (vertex == toV)
                            list.Remove(vertex);
                    }
                }
            }
        }

    }
}
