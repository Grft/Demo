using System;
using System.Text;

namespace Exercise3
{
    class Program
    {
        static void ReverseString(ref StringBuilder input)
        {
            char tmp;
            int len = input.Length;
            if (len <= 1)
                return;
            for (int l = 0, r = len - 1; l < r; l++, r--)
            {
                tmp = input[r];
                input[r] = input[l];
                input[l] = tmp;
            }
        }
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            Console.WriteLine("input a string:");
            input.Append(Console.ReadLine());
            ReverseString(ref input);
            Console.WriteLine(input.ToString());
        }
    }
}
