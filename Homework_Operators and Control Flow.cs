using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class Homework_Week4
    {
        static void Main1(string[] args)
        {
            ex10();
        }

        static void ex1() // Write a C# Sharp program to check whether a given number is even or odd.
        {
            Console.WriteLine("The number need checking: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            string check = (numb % 2 == 0) ? "It's even!" : "It's odd!";
            Console.WriteLine(check);
        }

        static void ex2() // Write a C# Sharp program to find the largest of three numbers.
        {
            Console.WriteLine("1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3rd number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(Math.Max(a, b), c);
            Console.WriteLine(" => The largest number is " + max);

            Console.ReadLine();
        }

        static void ex3() //Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        {
            Console.WriteLine("Input the value for X (X!=0): ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value for Y (Y!=0): ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First Quadrant");
            else if (x < 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second Quadrant");
            else if (x < 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third Quadrant");
            else if (x > 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth Quadrant");

            Console.ReadLine();
        }

        static void ex4 () // Write a program to check whether a triangle is Equilateral, Isosceles or Scalene
        {
            Console.WriteLine("Input the length of 1st side: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the length of 2nd side: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the length of 3rd side: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
                Console.WriteLine("Invalid!");
            else if ((a + b) > c)
                Console.WriteLine("This is a Scalene Triangle");
            else if (a == b || a == c || b == c)
                Console.WriteLine("This is a Isosceles Triangle");
            else if (a == b && a == c)
                Console.WriteLine("This is a Equilateral Triangle");
  
            Console.ReadLine();
        }

        static void ex5() // Write a program to read 10 numbers and find their average and sum.
        {
            Console.WriteLine("Input 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 3rd number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 4th number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 5th number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 6th number: ");
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 7th number: ");
            int num7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 8th number: ");
            int num8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 9th number: ");
            int num9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 10th number: ");
            int num10 = Convert.ToInt32(Console.ReadLine());

            double average = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10)/10D;
            int sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
            Console.WriteLine(" => Sum: " + sum);
            Console.WriteLine(" => Average: "+ average);

            Console.ReadLine();
        }

        static void ex6 () // 3. Write a program to display the multiplication table of a given integer.
        {
            Console.WriteLine("Which number do you want to see on the multiplication table? ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            int a1 = a*1 ; int a2 = a1*2; int a3 = a1*3 ; int a4 = a1*4 ; int a5 = a1*5 ; int a6 = a1*6 ; int a7 = a1*7 ; int a8 = a1*8 ; int a9 = a1*9 ; int a10 = a1*10 ;
            Console.WriteLine
           (@$"The multiplication table of number {a}:
               {a} x 1 = {a1}
               {a} x 2 = {a2}
               {a} x 3 = {a3}
               {a} x 4 = {a4}
               {a} x 5 = {a5}
               {a} x 6 = {a6}
               {a} x 7 = {a7}
               {a} x 8 = {a8}
               {a} x 9 = {a9}
               {a} x 10 = {a10}
                  ");
        }

        static void ex7a () // Write a program to display a pattern like triangles with a number
        {
            Console.WriteLine("Input the beginning number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the last number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int x = i; x <= n; x++) // outer loop for rows
            {
                for (int j = i; j <= x; j++) // inner lop for numbers each row
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }

        static void ex7b() // Write a program to display a pattern like triangles with a number
        {
            Console.WriteLine("Input the beginning number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the number of row that you want: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int z = i;  // các phần tử trong 1 hàng

            for (int x = 1; x <= n; x++) // outer loop for số hàng
            {
                for (int j=1; j <= x ; j++) // inner loop for số phần tử trong 1 hàng
                {
                    Console.Write(z+" "); // các phần tử hiện trong hàng
                    z++;
                }
                Console.WriteLine();
            }

        }

        static void ex7c() // Write a program to display a pattern like triangles with a number
        {
            Console.WriteLine("Input the beginning number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the number of row that you want: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int z = i;

            for (int x = 1; x <= n; x++) 
            {
                for (int y = x; y <=n; y++)
                {
                    Console.Write(" ");
                }

                Console.Write(" ");
                for (int j = 1; j <= x; j++)
                {
                    Console.Write(z + " "); 
                    z++;
                }
                Console.WriteLine();
            }

        }

        static void ex8() //Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        {
            Console.WriteLine("Input n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0d;

            for (int x = 1; x <= n; x++)
            {
                double a = 1.0 / x;
                if (x ==1)
                    Console.Write("1 ");
                else 
                    Console.Write($"+ 1/{x} ");
                sum += a;                       // add a to the sum
            }

            Console.Write("==> Sum of the series: "+sum);
        }

        static void ex9() // Write a program to find the ‘perfect’ numbers within a given number range
        {
            Console.WriteLine("From 1 to n, iput the range n you want to check: ");
            int n = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine();
            for (int x = 1;x <= n; x++)
            {
                int sum = 0;
                for (int y = 1; y < x; y++)
                {
                    int check = x % y;
                    if (check == 0)
                    {
                        sum += y; 
                    }
                }

                if (x == sum)
                {
                    Console.Write(x+" ");
                }
            }

            Console.Write("--> perfect number");

        }

        static void ex10() // Write a program to determine whether a given number is prime or not.
        {
            Console.WriteLine("Input a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int x = 1; x<=n; x++)
            {
                int check = n % x;
                if (check == 0)
                {
                    count++;
                }
            }
            if (count ==2)
                Console.WriteLine("It's prime!");
            else
                Console.WriteLine("It's not prime!");
        }

    }
}
