using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of diamond: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int nOfSpace = n - 1, nOfStar = 1;
            bool upHalf = true;
            n = n * 2 - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < nOfSpace; j++)
                    Console.Write(" ");
                for (int j = 0; j < nOfStar; j++)
                    Console.Write("*");
                Console.WriteLine();
                if (nOfSpace == 0)
                    upHalf = false;
                if (upHalf)
                {
                    nOfSpace--;
                    nOfStar += 2;
                    continue;
                }
                nOfSpace++;
                nOfStar -= 2;
            }
        }
    }
}
