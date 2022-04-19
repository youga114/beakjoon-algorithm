using System;
using System.Collections.Generic;
using System.Linq;

namespace _1520
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            
            List<string> mn = Console.ReadLine().Split(" ").ToList();
            m = Convert.ToInt32(mn[0]);
            n = Convert.ToInt32(mn[1]);

            var map = new List<List<int>>();
            map.Add(new List<int>(new int[n + 2]));
            for(int i = 0; i < m; ++i)
            {
                var line = new List<int>();
                line.Add(0);
                line.AddRange(Console.ReadLine().Split(" ").ToList().Select(x => Convert.ToInt32(x)));
                line.Add(0);
                map.Add(line);
            }
            map.Add(new List<int>(new int[n + 2]));
            
            var visitedCnt = new List<List<int>>();
            for (int i = 0; i < m + 2; ++i)
            {
                visitedCnt.Add(new List<int>(new int[n + 2]));
            }
            for (int i = 1; i < m + 1; ++i)
            {
                for (int j = 1; j < n + 1; ++j)
                {
                    visitedCnt[i][j] = -1;
                }
            }
            visitedCnt[1][1] = 1;

            Console.Write(getCnt(m, n, map, visitedCnt, map[m][n] - 1));
        }
        
        static int getCnt(int x, int y, List<List<int>> map, List<List<int>> visitedCnt, int prevH)
        {
            if (visitedCnt[x][y] != -1)
            {
                return visitedCnt[x][y];
            }

            if (prevH >= map[x][y])
            {
                return 0;
            }
            
            visitedCnt[x][y] = 0;
            visitedCnt[x][y] = getCnt(x + 1, y, map, visitedCnt, map[x][y]) + getCnt(x - 1, y, map, visitedCnt, map[x][y]) + getCnt(x, y + 1, map, visitedCnt, map[x][y]) + getCnt(x, y - 1, map, visitedCnt, map[x][y]);

            return visitedCnt[x][y];
        }
    }
}
