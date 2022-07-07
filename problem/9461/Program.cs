using System;
using System.Collections.Generic;
using System.Text;

namespace _9461
{
    class Program
    {
        static void Main(string[] args)
        {
            var dp = new List<ulong>(new ulong[101]);

            dp[1] = 1;
            dp[2] = 1;
            dp[3] = 1;
            for (int i = 4; i <= 100; ++i)
            {
                dp[i] = dp[i - 3] + dp[i - 2];
            }
            
            int t = Convert.ToInt32(Console.ReadLine());
            var sb = new StringBuilder();
            for (int i = 0; i < t; ++i)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                sb.Append(dp[n] + "\n");
            }

            Console.Write(sb.ToString());
        }   
    }
}