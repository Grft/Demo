using System;

namespace Exercise4
{
    class Program
    {
        static bool IsArmstrong(int n)
        {
            string num = Convert.ToString(n);
            int len = num.Length;
            int ans = 0;
            for (int i = 0; i < len; i++)
                ans += Convert.ToInt32(Math.Pow(num[i] - '0', len));
            Console.WriteLine(ans);
            return ans == n;
        }
        static void PrintArmstrong(int l, int r)
        {
            for (int i = l; i <= r; i++)
            {
                if (IsArmstrong(i))
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int l, r;
            Console.Write("input first number: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("input second number: ");
            r = Convert.ToInt32(Console.ReadLine());
            if (l < 0 || r < 0 || l > int.MaxValue || r > int.MaxValue)
            {
                Console.WriteLine("input out of int range");
                return;
            }
            PrintArmstrong(l, r);
        }
    }
}
