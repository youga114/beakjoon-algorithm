using System;
using System.Collections.Generic;
using System.Text;

namespace _11727
{
    class Program
    {
        static void Main(string[] args)
        {
            var dp = new List<int>(new int[1001]);

            dp[1] = 1;
            dp[2] = 3;

            for (int i = 3; i < 1001; ++i)
            {
                dp[i] = (dp[i - 1] + (dp[i - 2] * 2)) % 10007;
            }

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dp[n]);
        }
    }
}