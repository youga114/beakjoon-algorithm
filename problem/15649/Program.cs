using System;
using System.Collections.Generic;
using System.Text;

namespace _15649
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
            int n = nm[0], m = nm[1];

            StringBuilder sb = new StringBuilder();
            var answer = new List<int>(new int[m]);
            var visited = new List<bool>(new bool[n + 1]);
            dfs(n, m, 0, visited, answer, sb);
            
            Console.WriteLine(sb.ToString());
        }

        static void dfs(int n, int m, int curIdx, List<bool> visited, List<int> answer, StringBuilder sb)
        {
            if (curIdx >= m)
            {
                foreach (var i in answer)
                {
                    sb.Append(i + " ");
                }

                sb.Append("\n");

                return;
            }
            
            for (int i = 1; i <= n; ++i)
            {
                if (visited[i] == false)
                {
                    visited[i] = true;
                    answer[curIdx] = i;
                    dfs(n, m, curIdx + 1, visited, answer, sb);
                    visited[i] = false;
                }
            }
        }
    }
}