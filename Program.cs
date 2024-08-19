using System;
namespace Class3
{
    internal class Baitaptailop
    {
        static void Main(string[] args)
        {
            ex2();       
        }
        static void ex1 ()
        {
            float C, F, K;
            Console.Write($"Nhap do C: ");
            C = Convert.ToSingle(Console.ReadLine()); 
            F = C * 18 / 10 + 32;
            K = C + 273;
            Console.WriteLine($"=> do F = {F} va do K = {K}");
        }

        static void ex2()
        {
            //const float pi = 3.14f;
            Console.Write("Nhap ban kinh R= ");
            float R = Convert.ToSingle(Console.ReadLine());
            //float Surface = 4 * pi * (R*R);
            //float Volume = 4 / 3 * pi * (R * R * R);
            //Console.WriteLine($"Dien tich xung quanh: {Surface}" + $" The tich: {Volume}");

            double pi = Math.PI; // sử dụng thư viện 
            double Surface = 4 * pi * Math.Pow(R, 2);
            double Volume = 4 / 3 * pi * Math.Pow(R,3);
            Console.WriteLine($"Dien tich xung quanh: {Surface}" + $" The tich: {Volume}");
        }
        static void explicitcast()
        {
            int a = 1;
            long b = a;

            int c = (int) b; // ép kiểu từ long -> int, các kiểu số thì xài được, string thì no
            int c=Convert.ToInt32(c);
        }
        static void stringex1()
        {

        }

    }
}