using System;
using System.Collections.Generic;
using System.Text;

namespace _14719
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
            int h = hw[0], w = hw[1];

            var wall = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
            var rightMaxNum = new List<int>(new int[w]);
            var leftMaxNum = new List<int>(new int[w]);

            int maxNum = wall[0];
            for (int i = 1; i < w; ++i)
            {
                leftMaxNum[i] = maxNum;
                
                if (maxNum < wall[i])
                {
                    maxNum = wall[i];
                }
            }
            
            maxNum = wall[w - 1];
            for (int i = w - 2; i >= 0; --i)
            {
                rightMaxNum[i] = maxNum;
                    
                if (maxNum < wall[i])
                {
                    maxNum = wall[i];
                }
            }

            int answer = 0;

            for (int i = 0; i < w; ++i)
            {
                int leftMax = leftMaxNum[i], rightMax = rightMaxNum[i];
                int minNum = leftMax < rightMax ? leftMax : rightMax;
                
                if (wall[i] < minNum)
                {
                    answer += minNum - wall[i];
                }
            }
            
            Console.WriteLine(answer);
        }
    }
}