using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementatiosOfSortings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(8);
            list.Add(7);
            list.Add(6);
            list.Add(3);
            list.Add(6);
            list.Add(2);
            list.Add(6);
            list.Add(90);
            list.Add(12);
            printList(BubbleSort(list));
            //printList(MergeSort(list));
            Console.WriteLine(BinarySearch(list, 90));


        }
        private static int BinarySearch(List<int> list, int x)
        {
            int l = 0, r = list.Count - 1, m;
            while (l <= r)
            {
                m = (r - l) / 2 + l;
                Console.WriteLine("i= " + m + " v= " + list[m]);

                if (list[m] == x)
                    return m + 1;
                if (list[m] < x)
                {
                    l = m + 1;
                }
                else
                    r = m - 1;
            }
            return -1;
        }
        public static List<int> BubbleSort(List<int> list)
        {
            bool swapped;
            for (int i = 0; i < list.Count - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        swapped = true;
                    }

                }
                if (!swapped)
                    break;
            }
            return list;
        }
        public static List<int> MergeSort(List<int> list)
        {
            int l = 0, r = list.Count - 1, m = r / 2;
            if (r == l)
                return list;
            List<int> l1 = new List<int>();
            for (int i = 0; i <= (r - l) / 2; i++)
            {
                l1.Add(list[i + l]);
            }
            List<int> l2 = new List<int>();
            for (int i = (r - l) / 2 + 1; i <= r; i++)
            {
                l2.Add(list[i + l]);
            }
            l1 = MergeSort(l1);
            l2 = MergeSort(l2);
            return Merge(l1, l2);
        }
        private static List<int> Merge(List<int> l1, List<int> l2)
        {
            List<int> c = new List<int>();
            int i = 0, j = 0;
            while (i < l1.Count && j < l2.Count)
            {
                if (l1[i] < l2[j])
                {
                    c.Add(l1[i++]);
                }
                else if (l1[i] > l2[j])
                {
                    c.Add(l2[j++]);
                }
                else
                {
                    c.Add(l1[i++]);
                    c.Add(l2[j++]);
                }

            }
            if (i < l1.Count)
            {
                for (; i < l1.Count; i++)
                {
                    c.Add(l1[i]);
                }
            }
            else if (j < l2.Count)
            {
                for (; j < l2.Count; j++)
                {
                    c.Add(l2[j]);
                }
            }
            return c;
        }
        public static void printList(List<int> l)
        {
            foreach (var item in l)
            {
                Console.Write(" , " + item);
            }
            Console.WriteLine();
        }




    }
}
