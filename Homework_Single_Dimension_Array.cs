using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class Array_Week6
    {
        #region input and print
        /// <summary>
        /// Nhap du lieu random
        /// </summary>
        /// <param name="a">mang can nhap</param>
        static void InputRandomData(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i <a.Length;i++)
            {
                a[i] = rnd.Next(100);
            }
        }

        /// <summary>
        /// Nhap mang tu nguoi dung
        /// </summary>
        /// <param name="a"> mang can nhap</param>
        static void IputUserData(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                a[i] = Convert.ToInt32(Console.ReadLine());
                bool res = int.TryParse(Console.ReadLine(), out a[i]);
                if (!res)
                {
                    Console.WriteLine("Invalid! Try again");
                    i--;
                }
            }
        }

        /// <summary>
        /// In mang ra man hinh
        /// </summary>
        /// <param name="a">mang can in</param>
        static void PrintArray (int[] a)
        {
            Console.Write("The array including: ");
            foreach (int i in a)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        #endregion


        static void Main6()
        {
            Console.WriteLine("Input number of elements: ");
            int b = int.Parse(Console.ReadLine());
            int[] a = new int[b];
            InputRandomData(a);
            PrintArray (a);
            //CalculateAvarage (a);

            //FindNumber(a,out int value);

            //FindIndex(a, value);

            //RemoveElement(a, out int remove_num);

            //PrintArray(a);

            //MaxMin(a);

            //Reverse(a);

            FindDuplicates(a);
            
            PrintArray(a);
            
        }

        static void CalculateAvarage (int[] a)
        {
            double sum = 0d;
            foreach (int i in a)
            {  sum += i; }

            Console.WriteLine("The average value of array elements is: "+ sum/a.Length);
        }

        static void FindNumber(int[] a, out int value)
        {
            Console.WriteLine("Input the number you want to find in the array: ");
            value = Convert.ToInt32(Console.ReadLine());
            foreach (int i in a)
            {
                if (i == value)
                {
                    Console.WriteLine($"There is {value} in the array");
                    break;
                }
                else if (i == a[a.Length-1])
                        Console.WriteLine($"Cannot find {value} in the array");

            }
            Console.WriteLine();
        }

        static void FindIndex(int[] a, int value)
        {
            FindNumber(a, out value);

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] == value)
            //    {
            //        Console.WriteLine($"The {value} is {a[i+1]}th and at {i+1}  ");
            //    }
            //}

            int index = Array.IndexOf(a, value);

            if (index != -1)
                Console.WriteLine($"The {value} is at index {index} ");
            else 
                Console.WriteLine("Not found");

        }

        static void RemoveElement(int[] a,out int remove_num)
        {
            Console.WriteLine("Which number you want to remove: ");
            remove_num  = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++) 
            {
                if (remove_num == a[i])
                {
                    for (int j = i; j < a.Length-1; j++)
                    {
                        a[j] = a[j+1];
                    }
                }

            }
            Array.Resize(ref a, a.Length -1);
            
        }

        static void MaxMin(int[] a)
        {
            int max = a[0];
            int min = a[0];

            foreach (int i in a)
            {
                if (i > max) max = i;
                if (i < min) min = i;
            }
            Console.WriteLine("Max of the array is: " + max);
            Console.WriteLine("Min of the array is: " + min);
        }

        static void Reverse(int[] a)
        {
            int swap = 0;
            int start = 0;
            int end = a.Length-1;
            while (start < end)
            {
                swap = a[start];
                a[start] = a[end];
                a[end] = swap;

                start++;
                end--;
            }
            PrintArray(a);

            
        }   

        static void FindDuplicates(int[] a)
        {
            //int check = 0;
            
            //for (int i = 0; i < a.Length; i++) 
            //{
            //    int dup = 0;
            //    check = a[i];
            //    for (int j = 0; j<a.Length; j++)
            //    {
            //        if (a[j] == check)
            //            dup++;
            //    }
            //    if (dup >= 2)
            //    {
            //        Console.WriteLine($"{check} is duplicated");
            //    }
            //}
            //advoid multiple reports = HashSet<>

            //new approach

            Sort(a);
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == a[i+1])
                {
                    Console.WriteLine($"{a[i]} is duplecated");
                }

                while (i < a.Length && a[i] == a[i+1])
                {
                    i++;
                }
            }

        } // watch it

        static void Sort (int[] a)
        {
            int temp = 0;
            for (int i = 0;i < a.Length;i++)
            {
                for (int j = i; j<a.Length;j++)
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
            }
        }

        static void RemoveDuplicates(int [] a)
        {

        }
    }
}
