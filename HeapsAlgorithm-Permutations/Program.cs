using System;
using System.Linq;
using System.Collections.Generic;

namespace HeapsAlgorithm_Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var all = new List<List<int>>();

            // initialize
            string str = "12";
            int[] arr = str.Select(c => c - '0').ToArray();

            GetPer(arr, all);  // normal permutations example

            //GetPerAlternateParity(arr, all);  // alternating permutations example

            PrintAll(all);
        }

        private static void Swap(ref int a, ref int b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }

        public static void GetPer(int[] a, List<List<int>> all)
        {
            //int x = a.Length - 1;
            int x = a.Length - 1;
            GetPer(a.ToArray(), 0, x, all);
        }

        private static void GetPer(int[] a, int k, int m, List<List<int>> all)
        {
            if (k == m)
            {
                //Console.Write(list);
                //Console.WriteLine();

                List<int> l = new List<int>();
                l.AddRange(a);
                all.Add(l);

            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref a[k], ref a[i]);
                    GetPer(a, k + 1, m, all);
                    Swap(ref a[k], ref a[i]);
                }
        }

        public static void GetPerAlternateParity(int[] a, List<List<int>> all)
        {
            //int x = a.Length - 1;
            int x = a.Length - 1;
            GetPerAlternateParity(a.ToArray(), 0, x, all);
        }

        private static void GetPerAlternateParity(int[] a, int k, int m, List<List<int>> all)
        {
            if (k == m)
            {
                List<int> l = new List<int>();
                l.AddRange(a);
                all.Add(l);

            }
            else
                for (int i = k; i <= m; i++)
                {
                    bool isEven = ((a[k] + a[i]) % 2 == 0);

                    if (isEven)
                    {
                        Swap(ref a[k], ref a[i]);

                        GetPerAlternateParity(a, k + 1, m, all);
                    }
                    else if (a.Length == 2) {
                        Swap(ref a[k], ref a[i]);

                        GetPerAlternateParity(a, k + 1, m, all);
                    }


                    //isEven = ((a[k] + a[i]) % 2 == 0);

                    //if (isEven)
                    //    Swap(ref a[k], ref a[i]);
                }
        }

        private static void PrintAll(List<List<int>> a)
        {
            int counter = 1;
            foreach (var l in a)
            {
                Console.Write($"{counter,4} - ");

                foreach (var c in l)
                    Console.Write(c);

                Console.WriteLine();
                counter++;
            }
        }
    }
}
