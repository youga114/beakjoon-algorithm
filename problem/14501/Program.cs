using System;
using System.Collections.Generic;
using System.Text;

namespace _14501
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var dp = new List<int>(new int[n + 2]);

            int max = 0;
            for (int i = 1; i <= n; ++i)
            {                
                var taskDayAndMoney = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
                int taskDay = taskDayAndMoney[0], money = taskDayAndMoney[1];

                if (max < dp[i])
                {
                    max = dp[i];
                }

                if (i + taskDay <= n + 1 && dp[i + taskDay] < max + money)
                {
                    dp[i + taskDay] = max + money;
                }
            }

            if (dp[n + 1] > max)
            {
                max = dp[n + 1];
            }
            
            Console.WriteLine(max);
        }
    }
}