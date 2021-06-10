using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(b);
                    b = 1 - b;
                }
                Console.WriteLine();
            }
        }
    }
}
