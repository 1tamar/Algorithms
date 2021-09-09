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
            AdjacencyList<int> adjList = InitialBoard();
            int throwings = SnakeAndLadderProblem(adjList);
          //  PrintFar(adjList);
            Console.WriteLine("the minimum throwings to win: " + throwings);
        }


        //==================== SNAKES AND LADDER (based on BFS)=====
        public static int SnakeAndLadderProblem(AdjacencyList<int> adjList)
        {
            //  !!! With God's help, we will do and succeed !!
           
            Queue<List<Vertex<int>>> qTemp = new Queue<List<Vertex<int>>>();
            int i = 0;
            qTemp.Enqueue(adjList.MyList[i++]);
            int count = 0;
            while (qTemp.Count != 0 && i < adjList.CountVertices)
            {
                List<Vertex<int>> currV = qTemp.Peek();
                UpdateThrowings(currV);
                qTemp.Dequeue();
                qTemp.Enqueue(adjList.MyList[i++]);
            }
            Vertex<int> lastV = adjList.MyList[adjList.CountVertices - 1][adjList.MyList[adjList.CountVertices - 1].Count - 1];
            count = lastV.howManyThrow;
            return count;
        }
        public static void UpdateThrowings(List<Vertex<int>> currV)
        {
            foreach (var neighbor in currV)
            {
                //if ladder
                if (neighbor.Value > currV[0].Value + 1 && (neighbor.howManyThrow > currV[0].howManyThrow || neighbor.howManyThrow == -1))
                {
                    neighbor.FarFromPrevious = 6;
                    neighbor.howManyThrow = currV[0].howManyThrow;
                    neighbor.parent = currV[0];
                }
                else if(currV[0].howManyThrow < neighbor.howManyThrow||neighbor.howManyThrow==-1)
                {
                    if (currV[0].FarFromPrevious < 6 )
                    {
                        neighbor.FarFromPrevious = currV[0].FarFromPrevious + 1;
                        neighbor.howManyThrow = currV[0].howManyThrow;
                    }
                    else
                    {
                        neighbor.FarFromPrevious = 1;
                        neighbor.howManyThrow = currV[0].howManyThrow + 1;
                    }
                }
            }
        }

        //===========================INITIAL BOARD =======
        public static AdjacencyList<int> InitialBoard()
        {
            const int N = 30;
            //-----create the board-------
            AdjacencyList<int> adjList = new AdjacencyList<int>();
            Vertex<int> v = new Vertex<int>(0);
            adjList.AddVertex(v);
            for (int i = 1; i < N; i++)
            {
                v = new Vertex<int>(i);
                adjList.AddVertex(v);
                adjList.AddAdge(i - 1, i);
            }
            adjList.MyList[0][0].FarFromBase = 0;
            adjList.MyList[0][0].howManyThrow = 1;
            //ladders 
            adjList.AddAdge(11, 26);
            adjList.AddAdge(3, 22);
            adjList.AddAdge(5, 8);
            adjList.AddAdge(20, 29);
            //snakes
            adjList.AddAdge(27, 1);
            adjList.AddAdge(21, 9);
            adjList.AddAdge(17, 4);
            adjList.AddAdge(19, 7);
            return adjList;
        }


        //====================What is the distance in squares
        public static int SnakeAndLadderProblemSquares(AdjacencyList<int> adjList)
        {
            //  !!! With God's help, we will do and succeed !!
            adjList.MyList[0][0].FarFromBase = 0;
            adjList.MyList[0][0].howManyThrow = 0;

            Queue<List<Vertex<int>>> qTemp = new Queue<List<Vertex<int>>>();
            int i = 0;
            qTemp.Enqueue(adjList.MyList[i++]);
            int count = 0;
            while (qTemp.Count != 0 && i < adjList.CountVertices)
            {
                List<Vertex<int>> currV = qTemp.Peek();
                foreach (var neighbor in currV)
                {
                    //if ladder 
                    if (neighbor.Value > currV[0].Value + 1 && (neighbor.FarFromBase > currV[0].FarFromBase || neighbor.FarFromBase == -1))
                    {
                        neighbor.FarFromBase = currV[0].FarFromBase;
                        neighbor.parent = currV[0];
                        neighbor.howManyThrow = currV[0].howManyThrow;
                    }
                    else if (neighbor.FarFromBase != -1 && neighbor.FarFromBase > currV[0].FarFromBase + 1 || neighbor.FarFromBase == -1)
                    {
                        neighbor.FarFromBase = currV[0].FarFromBase + 1;
                        neighbor.parent = currV[0];
                    }
                }
                qTemp.Dequeue();
                qTemp.Enqueue(adjList.MyList[i++]);
            }
            Vertex<int> lastV = adjList.MyList[adjList.CountVertices - 1][adjList.MyList[adjList.CountVertices - 1].Count - 1];
            Console.WriteLine(lastV.howManyThrow);
            count = PrintStepsAndReturnCountSteps(adjList);
            return count;
        }

        //===========================PRINT ===============
        public static void PrintFar(AdjacencyList<int> adjList)
        {
            int i = 1;
            foreach (var list in adjList.MyList)
            {
                Console.WriteLine("list " + (i++) + " : ");
                foreach (var v in list)
                {
                    Console.Write("vertex: " + v.Value + " throwings: " + v.howManyThrow);
                }
                Console.WriteLine();
            }
        }
        public static int PrintStepsAndReturnCountSteps(AdjacencyList<int> adjList)
        {
            // the steps till the end
            Stack<Vertex<int>> steps = new Stack<Vertex<int>>();
            Vertex<int> v = adjList.MyList[adjList.CountVertices - 1][adjList.MyList[adjList.CountVertices - 1].Count - 1];
            steps.Push(v);
            while (steps.Peek().parent != null)
            {
                steps.Push(steps.Peek().parent);
            }
            int count = steps.Count;
            while (steps.Count != 0)
            {
                Console.Write(steps.Pop().Value + " ");
            }
            Console.WriteLine();
            return count;
        }

    }
}

