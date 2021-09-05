using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }
        public BinaryTree(T data)
        {
            Root = new Node<T>(data);
        }


    }
}
