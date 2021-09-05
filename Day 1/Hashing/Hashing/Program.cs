using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            //F1();
            //F2();
            F3();
            //F4();
        }


        public static void F1()
        {
            int[] arr = { 3, 4, 2, 3, 16, 3, 15, 16, 15, 15, 16, 2, 3 };
            Dictionary<int, int> fre = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (!fre.ContainsKey(item))
                    fre.Add(item, 1);
                else
                    fre[item]++;
            }

            if (fre.Count < 3)
                return;
            Tuple<int, int> max1 = new Tuple<int, int>(int.MinValue, 0);
            Tuple<int, int> max2 = new Tuple<int, int>(int.MinValue, 0);
            Tuple<int, int> max3 = new Tuple<int, int>(int.MinValue, 0);
            foreach (var item in fre)
            {
                if (item.Value > max1.Item2)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = new Tuple<int, int>(item.Key, item.Value);
                }
                else if (item.Value > max2.Item2)
                {
                    max3 = max2;
                    max2 = new Tuple<int, int>(item.Key, item.Value);
                }
                else if (item.Value > max3.Item2)
                {
                    max3 = new Tuple<int, int>(item.Key, item.Value);
                }
            }
            Console.WriteLine("first: " + max1.Item1 + " with value:" + max1.Item2);
            Console.WriteLine("second: " + max2.Item1 + " with value:" + max2.Item2);
            Console.WriteLine("third: " + max3.Item1 + " with value:" + max3.Item2);

        }
        public static void F2()
        {
            int[] arr1 = { 1, 2, 15, 4, 0 };
            int[] arr2 = { 2, 4, 15, 0, 1 };
            Console.WriteLine(AreEqual(arr1, arr2));
        }
        public static bool AreEqual(int[] arr1, int[] arr2)
        {
            //if (arr1.Length != arr2.Length)
            //    return false;
            Dictionary<int, int> fre = new Dictionary<int, int>();
            foreach (var item in arr1)
            {
                if (!fre.ContainsKey(item))
                    fre.Add(item, 1);
                else
                    fre[item]++;
            }
            foreach (var item in arr2)
            {
                if (!fre.ContainsKey(item))
                    return false;
                else
                    fre[item]--;
            }
            foreach (var item in fre)
            {
                if (item.Value != 0)
                    return false;
            }
            return true;
        }
        public static void F3()
        {
            int[] a = new int[] { 1, 2, 3, 1, 3 };

        }
        public static void F4()
        {
            int[] arr = { 1, 1, 2, 5, 7, 3, 3, 1, 9, 9,9,8,9,8,9 };
            Dictionary<int, int> fre = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (!fre.ContainsKey(item))
                    fre.Add(item, 1);
                else
                    fre[item]++;
            }

            foreach (var item in fre)
            {
                if (item.Value > 1)
                {
                    if (item.Value == 2)
                        Console.WriteLine("the key: " + item.Key + " with 1 pair");
                    else
                        Console.WriteLine("the key: " + item.Key + " with "+item.Value+" pairs");
                }

            }

        }
    }
}
