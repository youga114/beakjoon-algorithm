using System;
using System.Collections.Generic;
using System.Text;

namespace _2579
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var stairs = new List<int>(new int[1]);
            
            for (int i = 0; i < n; ++i)
            {
                stairs.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var dp = new List<int>(new int[n + 1]);
            dp[1] = stairs[1];

            if (n > 1)
            {
                dp[2] = stairs[1] + stairs[2];
            }

            for (int i = 3; i < n + 1; ++i)
            {
                int maxValue = (dp[i - 2] > stairs[i - 1] + dp[i - 3]) ? dp[i - 2] : stairs[i - 1] + dp[i - 3];
                dp[i] = stairs[i] + maxValue;
            }
            
            Console.WriteLine(dp[n]);
        }
    }
}