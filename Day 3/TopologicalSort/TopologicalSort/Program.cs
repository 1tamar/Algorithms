using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopologicalSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] adjMat = new int[,] { { 0, 1, 0, 1, 0, 0 },
                                         { 0, 0, 1, 1, 0, 0 },
                                         { 0, 0, 0, 1, 1, 1 },
                                         { 0, 0, 0, 0, 1, 1 },
                                         { 0, 0, 0, 0, 0, 1 },
                                         { 0, 0, 0, 0, 0, 0 }};
            int[] arr = TopologicSortBFS(adjMat);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i] + ", ");
            }

        }
        public static int[] TopologicSortBFS(int[,] adjMat)
        {
            int V = adjMat.GetLength(0);
            int[] T = new int[V];
            int[] visited = new int[V];
            int[] in_degree = new int[V];
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    if (adjMat[i, j] == 1)
                        in_degree[j]++;//degin of vertax j.
                }
            }
            for (int i = 0; i < V; i++)
            {
                if (in_degree[i] == 0)
                {
                    q.Enqueue(i);
                    visited[i] = 1;
                }
            }
            int curVertax;
            int current = 0;
            while (q.Count != 0)
            {
                curVertax = q.Dequeue();
                T[current++] = curVertax;
                for (int i = 0; i < V; i++)
                {
                    if (adjMat[curVertax, i] > 0 && visited[i] == 0)
                    {
                        in_degree[i] = in_degree[i] - 1;
                        if (in_degree[i] == 0)
                        {
                            q.Enqueue(i);
                            visited[i] = 1;
                        }
                    }

                }

            }
            return T;
        }
    }
}
