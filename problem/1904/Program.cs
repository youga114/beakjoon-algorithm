using System;
using System.Collections.Generic;
using System.Text;

namespace _1904
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var dp = new List<int>(new int[n + 1]);
            dp[1] = 1;

            if (n >= 2)
            {
                dp[2] = 2;
            }

            for (int i = 3; i < n + 1; ++i)
            {
                dp[i] = (dp[i - 1] + dp[i - 2]) % 15746;
            }

            Console.WriteLine(dp[n]);
        }
    }
}