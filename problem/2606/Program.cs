using System;
using System.Collections.Generic;

namespace _2606
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int pairCnt = Convert.ToInt32(Console.ReadLine());

            var graph = new List<List<int>>();
            for (int i = 0; i < n + 1; ++i)
            {
                graph.Add(new List<int>());
            }

            for (int i = 0; i < pairCnt; ++i)
            {
               var edge = Console.ReadLine().Split(' ');
               int from = Convert.ToInt32(edge[0]);
               int to = Convert.ToInt32(edge[1]);
               
               graph[from].Add(to);
               graph[to].Add(from);
            }

            var isVisited = new List<bool>(new bool[n + 1]);
            
            Console.WriteLine(dfs(1, graph, isVisited) - 1);
        }

        static int dfs(int from, List<List<int>> graph, List<bool> isVisited)
        {
            isVisited[from] = true;

            int answer = 1;
            
            for (int i = 0; i < graph[from].Count; ++i)
            {
                if (isVisited[graph[from][i]] == false)
                {
                    answer += dfs(graph[from][i], graph, isVisited);
                }
            }

            return answer;
        }
    }
}