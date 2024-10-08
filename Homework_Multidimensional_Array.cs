using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class test
    {
        static void Mainn(string[] args)
        {
            //JaggedArray_ex2();
            JaggedArray_ex3();

        }

        static void Rectang2D(int[] a)
        {
            int[,] c =
           {
                {1,2,3 }, {4,5,6}, {7,8,9 }
            };

            int[,] b = new int[3, 4];

            foreach (int i in c)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                    Console.Write($"{c[i, j]}\t");
                Console.WriteLine();

            }
        }

        static void JaggedArray_ex1()
        {
            int[][] a = new int[4][]
            {
               new int[] {1,1,1,1 },
               new int [] {2,2 },
               new int [] {3,3,3,3},
               new int [] {4,4},
            };


            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                    Console.Write($"{a[i][j]}");

                Console.WriteLine();
            }

        }

        #region Ex2
        static void JaggedArray_ex2()
        {
            Console.WriteLine("Input the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int[][] a = new int[rows][];
            Console.WriteLine();

            RandomInput(a);
            //UserInput(a);
            Print2D(a);
            //Max(a);

            //AscendingSort(a);
            //Print2D(a);

            FindIndex(a);
        }

        static void RandomInput(int[][] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                int cols = rnd.Next(2, 8);
                a[i] = new int[cols];
                for (int j = 0; j < a[i].Length; j++)
                    a[i][j] = rnd.Next(0, 50);
            }

        }

        static void Print2D(int[][] a)
        {
            Console.WriteLine("Print array -> ");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                    Console.Write($"{a[i][j]}\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void UserInput(int[][] a)
        {
            int rows = a.Length;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Input the number of columns u want in {i + 1}th row: ");
                int cols = int.Parse(Console.ReadLine());
                a[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"{j + 1}th of row {i + 1} is: ");
                    a[i][j] = int.Parse(Console.ReadLine());
                }

            }

        }

        static void Max(int[][] a)
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                max = 0;
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (max < a[i][j])
                        max = a[i][j];
                }
                Console.WriteLine($"Max of {i + 1}th row is: " + max);
            }
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (max < a[i][j])
                        max = a[i][j];
                }
            }
            Console.WriteLine($"Max of whole array is: " + max);

        }

        static void AscendingSort(int[][] a)
        {
            Console.WriteLine("After sorting =");
            for (int i = 0; i < a.Length; i++)
            {
                SortArray(a[i]);
            }
        }

        static void SortArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length - 1; j++)
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }

        }

        static void FindIndex(int[][] a)
        {
            Console.WriteLine("Which num you want to find: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (value == a[i][j])
                        Console.WriteLine($"{value} is found at {i + 1}th row and {j + 1}th column");
                }
        }
        #endregion

        static void JaggedArray_ex3()
        {

        }
    }
}
    
