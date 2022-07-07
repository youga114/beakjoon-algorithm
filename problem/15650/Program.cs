using System;
using System.Collections.Generic;
using System.Text;

namespace _15650
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
            int n = nm[0], m = nm[1];

            var answer = new List<int>(new int[m]);
            
            
            for (int i = 1; i <= n; ++i)
            {
                answer[0] = i;
                dfs(answer, 1, i + 1, n, m);
            }
        }

        static void dfs(List<int> answer, int idx, int value, int n, int m)
        {
            if (idx >= m)
            {
                for (int i = 0; i < m; ++i)
                {
                    Console.Write(answer[i] + " ");
                }
                Console.WriteLine();
                return;
            }
            
            for (int i = value; i <= n; ++i)
            {
                answer[idx] = i;
                dfs(answer, idx + 1, i + 1, n, m);
            }
        }
    }
}