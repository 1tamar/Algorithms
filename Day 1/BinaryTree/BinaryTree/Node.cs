using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Right { get; set; }
        public Node<T> Left { get; set; }

        public Node(T data)
        {
            Data = data;
            Right = Left = null;

        }
        public Node(T data, Node<T> rigth, Node<T> left)
        {
            Data = data;
            Right = rigth;
            Left = left;
        }

    }
}
