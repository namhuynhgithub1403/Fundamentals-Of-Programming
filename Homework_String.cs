using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class string_Week8
    {
        static void Main(string[] args)
        {
            //InputString(out string s);
            string s = "    hom nay    Nong   vl  40 do    ";
            Console.WriteLine(s);
            string h = "      am nay    Nong   vl  40 do    ";
            //Length(s);
            //SeparateChar(s);

            //Console.WriteLine();
            //ReverseIndividualChar(s);

            //Console.WriteLine("This sentence has " + CountWords(s) +" words");

            //Console.WriteLine(Compare(s, h));


        }
        static void InputString(out string s)
        {
            Console.WriteLine("Write a sentence: ");
            s = Console.ReadLine();
        }

        

        static void Length(string s)
        {
            int length = 0;
            foreach (var item in s)
            {
                length++;
            }
            Console.WriteLine(length);

            Console.WriteLine(s.Length);
        }

        static void SeparateChar(string s)
        {
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] != ' ')
                    Console.Write($"{s[i]}  ");
                i++;
            }
        }

        static void ReverseIndividualChar(string s)
        {
            string rev = ""; 
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i];
            }
            Console.WriteLine(rev);
        }   

        static int CountWords(string s)
        {
            s=s.Trim();
            int count = 0;
            if (!string.IsNullOrEmpty(s))
                count = 1;

            for (int i = 0; i < s.Length -1; i++)
            {
                if (s[i] == ' ' && s[i+1] != ' ')
                    count++;
            }

            return count;
        }

        static string Compare(string s, string h)
        {
            if (s.Length != h.Length)
                return "Hong bang";

            for (int i = 0;i < s.Length;i++)
            {
                if (s[i] != h[i])
                    return "Giong nha";
            }
            return "Hong bang";
        }
    }
}
