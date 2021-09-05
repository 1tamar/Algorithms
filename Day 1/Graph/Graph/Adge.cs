using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Adge<T>
    {
        //private int weight = 1;
        //private Vertex<T> from;
        //private Vertex<T> to;

        //public void SetFromV(Vertex<T> from)
        //{
        //    this.from = from;
        //}
        //public Vertex<T> GetFromV()
        //{
        //    return this.from;
        //}
        //public void SetToV(Vertex<T> to)
        //{
        //    this.to = to;
        //}
        //public Vertex<T> GetToV()
        //{
        //    return this.to;
        //}
        //public void SetWeight(int weight)
        //{
        //    this.weight = weight;
        //}
        //public int GetWeight()
        //{
        //    return this.weight;
        //}

   
        public int From { get; set; }
        public int To { get; set; }

        public Adge(int from,int to)
        {
            From = from;
            To = to;
        }
    }
}
