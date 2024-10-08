using System;
namespace Sample
{
    internal class Baitap_buoi2
    { 
        static void Main1 (string[] args)
        {
            ex5();
        }

   
        static void ex1a()
        {
            int val = 55;
            Console.WriteLine("Hello" + "World");
            Console.WriteLine("Value = " + val);
            Console.WriteLine("Value = {0}, val");
        }

        static void ex1b()
        {
            int a, b, c;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Dap an: {0} ", c);
        }

        static void ex2() // 2. to Swap Values of Two Variables.
        {
            int a = 5, b = 3;
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"after swap a={a}, b={b}");
        }

        static void ex3() // 3. to Multiply two Floating Point Numbers
        {
            double a, b; 
            Console.Write("Nhap a: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dap an: {0}", a * b);
        }

        static void ex4() // 4. to convert feet to meter
        {
            double feet;
            Console.Write("feet: ");
            feet = Convert.ToDouble(Console.ReadLine());
            Console.Write($" => Meter: {feet * 0.3048}");
        }

        static void ex5() //5. to convert Celsius to Fahrenheit and vice versa
        {
            float C, F;
            Console.WriteLine("Nhap do C: ");
            C = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Do F: {F = (9 / 5 * C) + 32}");
            F = Convert.ToSingle(Console.ReadLine());
        }

    }

}