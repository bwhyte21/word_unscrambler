using System;
using System.Collections.Generic;

namespace WordUnscrambler_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // LISTS - grows dynamically
            /////////////////////////////
            //List<int> l_demoList = new List<int>();
            // OR
            var l_demoList = new List<int>();

            Console.WriteLine("Nodes in demoList: {0}", l_demoList.Count);

            l_demoList.Add(10);
            l_demoList.Add(5);

            Console.WriteLine("Nodes in demoList: {0}", l_demoList.Count);

            // ARRAYS - has initial capacity
            /////////////////////////////////
            var a_demoArray = new int[10];

            Console.WriteLine("Nodes in demoArray: {0}", a_demoArray.Length);

            foreach (var item in a_demoArray)
            {
                a_demoArray[item] = 1;
            }

            Console.WriteLine("Nodes in demoArray: {0}", a_demoArray.Length);

            /*int[] a_demoArray2 = new int[5];
            a_demoArray2[0] = 8;
            a_demoArray2[1] = 5;
            a_demoArray2[2] = 9;
            a_demoArray2[3] = 1;
            a_demoArray2[4] = 3;*/

            // OR

            int[] a_demoArray2 = { 8, 5, 9, 1, 3 };

            Console.WriteLine("Unorted demoArray2: ");
            Console.WriteLine("[{0}]", string.Join(", ", a_demoArray2));

            // SORT
            Array.Sort(a_demoArray2);

            Console.WriteLine("Sorted demoArray2: ");
            Console.WriteLine("[{0}]", string.Join(", ", a_demoArray2));


            /* Keep the console window open til user applies input */
#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}