using System;
using System.Collections.Generic;
using System.Text;

namespace _11659
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
            int n = nm[0], m = nm[1];

            var nums = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();

            var sums = new List<int>(new int[n + 1]);

            for (int i = 1; i <= n; ++i)
            {
                sums[i] = nums[i - 1] + sums[i - 1];
            }
            
            StringBuilder sb = new StringBuilder();
            
            while (m-- != 0)
            {
                var numRange = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();

                int sum = 0;

                sb.Append((sums[numRange[1]] - sums[numRange[0] - 1]) + "\n");
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}