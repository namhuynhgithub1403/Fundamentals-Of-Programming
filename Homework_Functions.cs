using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class HomeworkWeek5_Functions
    {
        static void Main1(string[] args)
        {
            //BT1(); // find the maximum of three numbers.
            //BT2(); // sum all the numbers in a list. 
            //BT3();
            //BT4_1();
            //BT4_2();
            //BT5_1();
            //BT5_2();
        }
       
        static void BT1() // find the maximum of three numbers.
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("The maximum of three: " + max(x, y, z));
            
        

            static int max(int a, int b, int c)
            {
                int max = Math.Max(Math.Max(a, b), c);
                return max;
            }
        }

        static void BT2() // calculate the factorial of a number (a non-negative integer). The functions accepts the number as an argument. 
        {
            Console.Write("The factorial of ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("-> is: " + numRecursion(num));

            //static int numRecursion (int a)
            //{
            //    int factorial = 1;
            //    for (int i = 1; i <= a; i++ )
            //    {
            //        factorial *= i;
            //    }
            //    return factorial;
            //}

            static long numRecursion (int n)
            {
                if (n == 0) return 1; 
                
                return n*numRecursion(n-1);

            }
        }

        static void BT3() // take a number as a parameter  and check whether it is prime or not.    
        {
            Console.WriteLine("Prime Number check: ");
            int n = Convert.ToInt32(Console.ReadLine());
            primeCheck(n);
            Console.WriteLine(primeCheck(n));

           
        }
        static bool primeCheck(int n)
        {
            int count = 0;
            for (int i = 1; i <= n;  i++)
            {
            if (n % i == 0) count++;
            }

            if (count == 2) return true;
            else return false;
        }

        static void BT4_1() // print all prime number that less than a given number (enter prompt keyborad) 
        {
            Console.WriteLine("Input the number: ");
            int n_input= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Here is the list of prime number which is less than " + n_input);

            for (int i = 1; i <= n_input ; i++)
            {
               if (primeCheck(i) == true)
                    Console.WriteLine("." + i);
            }
        }

        static void BT4_2() // print the first N prime number 
        {
            Console.WriteLine("How many prime number you want to print: ");
            int n_count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Here your ans");

            printNum(n_count);
            static void printNum(int n)
            {
                int count = 1;
                int num = 1;

                while (count <= n)
                {
                    if (primeCheck(num))
                    {
                        Console.WriteLine(num);
                        count++;
                    }
                    num++;
                }
            }

        }

        static void BT5_1() // check whether the number is "perfect" or not.
        {
            Console.WriteLine("Input the number need checking: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(isPerfect(n));

        }
        static bool isPerfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n) return true;
            else return false;
        }

        static void BT5_2() // print all perfect number that is less than 1000
        {
            Console.WriteLine("Here is the number that is less than 1000");
            printPerfectNum(1000);

            static void printPerfectNum(int n)
            {
                int num = 1;
                while (num <= n)
                {
                    if (isPerfect(num))
                    {
                        Console.WriteLine(num);
                    }
                    num++;
                }
            }

        }
    }
}
