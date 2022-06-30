using System;
using System.Collections.Generic;
using System.Text;

namespace _10844
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var dp = new List<List<int>>();

            for (int i = 0; i < n + 1; ++i)
            {
                dp.Add(new List<int>(new int[10]));
            }
            
            for (int i = 1; i < 10; ++i)
            {
                dp[1][i] = 1;
            }

            for (int i = 2; i < n + 1; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    if (j == 0)
                    {
                        dp[i][j] = dp[i - 1][j + 1];
                    }
                    else if (j == 9)
                    {
                        dp[i][j] = dp[i - 1][j - 1];
                    }
                    else
                    {
                        dp[i][j] = dp[i - 1][j - 1] + dp[i - 1][j + 1];
                    }
                    
                    if (dp[i][j] > 1000000000)
                    {
                        dp[i][j] %= 1000000000;
                    }
                }
            }

            int answer = 0;
            
            for (int i = 0; i < 10; ++i)
            {
                answer += dp[n][i];
                if (answer > 1000000000)
                {
                    answer %= 1000000000;
                }
            }
            
            Console.WriteLine(answer);
        }
    }
}