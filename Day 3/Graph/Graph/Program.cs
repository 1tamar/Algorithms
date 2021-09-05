using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = SnakeAndLadderProblem();
            Console.WriteLine("the minimum steps to win: " + steps);
        }
        //==================== SNAKES AND LADDER =====
        public static int SnakeAndLadderProblem()
        {
            //  !!! With God's help we will do and succeed !!!

            //-----create the board-------
            List<Vertex<int>> adjList = initialBoard();
            // my steps-1||2||3||4||5||6
            BFS(adjList);
            //Queue<Vertex<int>> qTemp = new Queue<Vertex<int>>();
            //qTemp.Enqueue(adjList[0]);
            //adjList[0].FarFromBase = 0;
            //adjList[0].parent = null;
            //while (qTemp.Count != 0)
            //{
            //    Vertex<int> currV = qTemp.Dequeue  ();
            //    foreach (var neighbor in currV.Neighbors)
            //    {
            //        if (neighbor.IsVisited == false)
            //        {
            //            neighbor.IsVisited = true;
            //            neighbor.FarFromBase = neighbor.FarFromBase + 1;
            //            neighbor.parent = currV;
            //            qTemp.Enqueue(neighbor);
            //        }
            //    }
            //    qTemp.Dequeue();
            //}
            return 0;

        }
        public static List<Vertex<int>> initialBoard()
        {

            //-----create the board-------
            List<Vertex<int>> adjList = new List<Vertex<int>>();
            const int n = 30;
            //base mode:
            for (int i = 0; i < n - 1; i++)
            {
                Vertex<int> v = new Vertex<int>(i);
                Vertex<int> vn = new Vertex<int>(i + 1);
                v.AddEdge(vn);
                adjList.Add(v);
            }
            adjList.Add(adjList[n - 2].Neighbors[0]);
            //spicial modes:-------------
            //Ladders :
            adjList[10].AddEdge(adjList[25]);
            adjList[2].AddEdge(adjList[21]);
            adjList[4].AddEdge(adjList[7]);
            adjList[19].AddEdge(adjList[28]);
            //snakes:
            adjList[26].AddEdge(adjList[0]);
            adjList[20].AddEdge(adjList[8]);
            adjList[16].AddEdge(adjList[3]);
            adjList[18].AddEdge(adjList[6]);
            return adjList;
        }
    }
}
