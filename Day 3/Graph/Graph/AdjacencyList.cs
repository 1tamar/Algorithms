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
        private List<List<Vertex<T>>> MyList;
        public AdjacencyList(int countVertices)
        {
            MyList = new List<List<Vertex<T>>>();
        }
        public void AddVertex(Vertex<T> v)
        {
            List<Vertex<T>> newList = new List<Vertex<T>>();
            newList.Add(v);
            MyList.Add(newList);
            countVertices++;
        }
        public void AddAdge(Vertex<T> fromV,Vertex<T> toV)
        {
            bool flag = false;
            foreach (var list in MyList)
            {
                if (list[0] == fromV)
                {
                    list.Add(toV);
                    flag = true;
                    break;
                }

            }
            if(!flag)
            {
                List<Vertex<T>> newList = new List<Vertex<T>>();
                newList.Add(fromV);
                newList.Add(toV);
                MyList.Add(newList);
                countVertices++;
            }

        }
        public void RemoveAdge(Vertex<T> fromV, Vertex<T> toV)
        {
            foreach (var list in MyList)
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
