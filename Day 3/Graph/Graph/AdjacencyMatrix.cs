using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class AdjacencyMatrix
    {
        private int countVertices ;
        private int[,] mat;
        public AdjacencyMatrix(int countVertices)
        {
            this.countVertices = countVertices;
            mat = new int [countVertices, countVertices];
        }
        public void AddAdge(int i, int j)
        {
            mat[i, j] = 1;
        }
        public void RemoveAdge(int i, int j)
        {
            mat[i, j] = 0;
        }
        public void AddVertex()
        {
            countVertices++;
            int[,] temp = new int[countVertices + 1, countVertices + 1];
            for (int i = 0; i < countVertices; i++)
            {
                for (int j = 0; j < countVertices; j++)
                {
                    temp[i, j] = mat[i, j];
                }
            }
            mat = temp;
        }
    }
}
