using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    class ArraysExample
    {
        static void Main(string[] args)
        {
            // Declaration
            //int[] arr = new int[5];
            // Assignation
            //arr[0] = 100;
            //arr[1] = 200;
            //arr[2] = 300;
            //arr[3] = 400;
            //arr[4] = 500;
            //Initialization
            //int[] arr1 = new int[5] { 1001, 1002, 1003, 1004, 1005 };

            //int[] arr1 = new int[5] { 1001, 1002, 1003, 1004, 1005 };

            // 1st Way to Print Array Elements
            //for (int i = 0; i <= 4; i++)
            //    Console.WriteLine(arr1[i]);

            //Console.WriteLine("************************************");

            // 2nd Way to Print Array Elements
            //for (int i = 0; i < arr1.Length; i++)
            //    Console.WriteLine(arr1[i]);

            //Console.WriteLine("************************************");

            // 3rd Way to Print Array Elements
            //foreach (var item in arr1)
            //    Console.WriteLine(item);

            // 1st Way to Print Array Elements
            //for (int i = 0; i <= 4; i++)
            //{
            //    if(i%2 != 0)
            //        Console.WriteLine(arr1[i]);
            //}

            //Console.WriteLine("************************************");

            // 2nd Way to Print Array Elements
            //for (int i = 0; i < arr1.Length; i++)
            //    Console.WriteLine(arr1[i]);

            //Console.WriteLine("************************************");

            // 3rd Way to Print Array Elements
            //foreach (var item in arr1)
            //{
            //    if (item == 1003)
            //        continue;
            //    Console.WriteLine(item);
            //}

            // Demonstrating Multi-Dimensional Arrays
            //int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //for (int i = 0; i <= 1; i++)
            //{
            //    for (int j = 0; j <= 2; j++)
            //    {
            //        Console.Write(arr1[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //int[][] arr1 = new int[3][];

            //arr1[0] = new int[5] { 1, 2, 3, 4, 5 };
            //arr1[1] = new int[3] { 1, 2, 3 };
            //arr1[2] = new int[6] { 1, 2, 3, 4, 5, 6 };

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    for (int j = 0; j < arr1[i].Length; j++)
            //    {
            //        Console.Write(arr1[i][j] + "    ");
            //    }
            //    Console.WriteLine();
            //}

            int[] arr1 = new int[6] { 5, 8, 9, 20, 2, 7 };
            int[] arr2 = new int[6];
            Console.WriteLine("Length of First Array : " + arr1.Length);
            Console.WriteLine("************************************");
            Console.WriteLine("Sorted Array in Ascending Order : ");
            Array.Sort(arr1);
            foreach (var item in arr1)
                Console.WriteLine(item);
            //Console.WriteLine("************************************");
            Console.WriteLine("Sorted Array in Descending Order : ");
            Array.Reverse(arr1);
            foreach (var item in arr1)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
