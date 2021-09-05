using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = new Node<int>(10);
            root.Left = new Node<int>(20);
            root.Right = new Node<int>(30);
            root.Left.Left = new Node<int>(40);
            root.Left.Right = new Node<int>(50);
            root.Right.Left = new Node<int>(40);
            root.Right.Right = new Node<int>(50);
            root.Left.Left.Left = new Node<int>(1000);
            root.Right.Right.Right = new Node<int>(1000);

            //  NthNode(root, 4);
            Console.WriteLine(IsAllLeavesInSameLevel(root));
        }
        static int c = 0;
        public static void NthNode(Node<int> node, int n)
        {
            if (node == null)
                return;
            if (c <= n)
            {
                NthNode(node.Left, n);
                //Console.WriteLine(node.Data);
                c++;
                //n -= 1;
                if (n == c)
                {
                    Console.WriteLine(" " + node.Data);
                    return;
                }
                NthNode(node.Right, n);
            }

            //if (node != null)
            //{
            //    NthInorder(node.Left, n);
            //    n--;
            //    if (n == 0)
            //        Console.WriteLine(node.Data);
            //    else
            //        NthInorder(node.Right, n);
            //}
        }

        public static bool IsAllLeavesInSameLevel(Node<int> node)
        {
     

            return IsAllLeavesInSameLevel(node.Left) == IsAllLeavesInSameLevel(node.Right);
        }
        public static int Height(Node<int> node)
        {
            if (node.Left == null && node.Right == null)
                return 1;

                if (node == null || node.Left == null && node.Right == null)
                return 0;
            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

    }
}
