using System;
using System.Collections.Generic;
using System.Text;

namespace _15651
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
            int n = nm[0], m = nm[1];

            var answer = new List<int>(new int[m]);
            var sb = new StringBuilder();
            
            dfs(answer, 0, n, m, sb);
            
            Console.WriteLine(sb.ToString());
        }

        static void dfs(List<int> answer, int idx, int n, int m, StringBuilder sb)
        {
            if (idx >= m)
            {
                for (int i = 0; i < m; ++i)
                {
                    sb.Append(answer[i] + " ");
                }

                sb.Append("\n");
                return;
            }

            for (int i = 1; i <= n; ++i)
            {
                answer[idx] = i;
                dfs(answer, idx + 1, n, m, sb);
            }
        }
    }
}