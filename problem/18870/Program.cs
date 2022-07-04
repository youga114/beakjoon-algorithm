using System;
using System.Collections.Generic;
using System.Text;

namespace _18870
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var nums = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();

            var sortedNums = new List<int>(nums);
            sortedNums.Sort();
            sortedNums = sortedNums.Distinct().ToList();

            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < n; ++i)
            {
                sb.Append(sortedNums.BinarySearch(nums[i]) + " ");
            }
            
            Console.WriteLine(sb.ToString());
        }   
    }
}