using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        /*
         i tried to implement the graph'
         but it didn't go so well...
         so I looked for an exisist implementation.
         I read and understood it
         and relied on it.
         */
        static void Main(string[] args)
        {
            //Ex1();
            // Ex2();
            //BFS(CreateAdjList());

        }


        //==================== STEPPNIG NUMBERS =======
        private static void Ex1()
        {
            int from = 0, to = 21;
            Console.WriteLine("The count of the stepping numbers between " + from + " to " + to + " : " +
                              PrintSteppingNumbersByBFS(from, to));
        }
        public static int PrintSteppingNumbersByBFS(int from, int to)
        {
            Queue<int> q = new Queue<int>();
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                q.Enqueue(i);
            }
            while (q.Count != 0)
            {
                int current = q.Dequeue();
                if (current <= to && current >= from)
                {
                    Console.Write(" " + current);
                    count++;
                }
                if (current == 0 || current > to)
                    continue;
                int lastDigit = current % 10;
                if (lastDigit == 0)
                    q.Enqueue(current * 10 + lastDigit + 1);
                else if (lastDigit == 9)
                    q.Enqueue(current * 10 + lastDigit - 1);
                else
                {
                    q.Enqueue(current * 10 + lastDigit + 1);
                    q.Enqueue(current * 10 + lastDigit - 1);
                }
            }
            Console.WriteLine();
            return count;

        }


        //==================== TREES IN FOREST =======
        private static void Ex2()
        {
            List<Vertex<int>> n1 = new List<Vertex<int>>();
            List<Vertex<int>> n2 = new List<Vertex<int>>();
            List<Vertex<int>> n3 = new List<Vertex<int>>();
            List<Vertex<int>> n4 = new List<Vertex<int>>();


            Vertex<int> v3 = new Vertex<int>(4);
            Vertex<int> v4 = new Vertex<int>(5);
            Vertex<int> v6 = new Vertex<int>(7);
            Vertex<int> v7 = new Vertex<int>(8);
            Vertex<int> v9 = new Vertex<int>(10);
            Vertex<int> v10 = new Vertex<int>(11);
            Vertex<int> v11 = new Vertex<int>(12);

            n4.Add(v9);
            n4.Add(v10);
            n4.Add(v11);

            //first tree----------- 2,3,4,10,11,12
            Vertex<int> v2 = new Vertex<int>(3, n4);
            n1.Add(v2);
            n1.Add(v3);
            Vertex<int> v1 = new Vertex<int>(2, n1);
            //second tree----------- 6,7,8
            n2.Add(v6);
            n2.Add(v7);
            Vertex<int> v5 = new Vertex<int>(6, n2);
            //third tree-----------10,5
            n3.Add(v4);
            Vertex<int> v8 = new Vertex<int>(10, n3);
            Vertex<int>[] myVertexs = { v1, v2, v3, v5, v6, v7, v8, v4 };
            GraphRealization<int> myGraph = new GraphRealization<int>(myVertexs);
            DFS(myGraph);


        }


        //==================== DFS =======
        public static void Explore(Vertex<int> vertex)
        {
            foreach (var neighbor in vertex.Neighbors)
            {
                if (!neighbor.IsVisited)
                {
                    Console.Write(" " + neighbor.Value + ", ");
                    neighbor.IsVisited = true;
                    Explore(neighbor);
                }

            }
        }
        public static void DFS(GraphRealization<int> myGraph)
        {
            int cnt = 0;

            foreach (var vertex in myGraph.Vertices)
            {
                if (!vertex.IsVisited)
                {
                    Console.Write("Tree " + (cnt + 1) + " with vertexs: " + vertex.Value + ", ");
                    vertex.IsVisited = true;
                    Explore(vertex);
                    cnt++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("the forest graph contain " + cnt + " trees.");

        }


        //==================== BFS ========
        public static void BFS(List<Vertex<int>> adjList)
        {
            Queue<Vertex<int>> qTemp = new Queue<Vertex<int>>();
            qTemp.Enqueue(adjList[0]);
            adjList[0].FarFromBase = 0;
            adjList[0].parent = null;
            Console.Write(" " + adjList[0].Value + ", ");
            while (qTemp.Count != 0)
            {
                Vertex<int> currV = qTemp.Dequeue();
                foreach (var neighbor in currV.Neighbors)
                {
                    if (neighbor.IsVisited == false)
                    {
                        Console.Write(" " + neighbor.Value + ", ");
                        neighbor.IsVisited = true;
                        neighbor.FarFromBase = neighbor.FarFromBase + 1;
                        neighbor.parent = currV;
                        qTemp.Enqueue(neighbor);
                    }
                }
            }

        }


    }
}
