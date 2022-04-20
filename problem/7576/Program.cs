using System;
using System.Collections.Generic;
using System.Linq;

namespace _7576
{
    class Program
    {
        static void Main(string[] args)
        {
            var mn = Console.ReadLine().Split(" ").ToList();
            int n = Convert.ToInt32(mn[1]), m = Convert.ToInt32(mn[0]);

            var map = new List<List<int>>();
            map.Add(new int[m + 2].Select((x) => -1).ToList());
            for (int i = 0; i < n; ++i)
            {
                List<int> list = new List<int>();
                list.Add(-1);
                list.AddRange(Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList());
                list.Add(-1);
                map.Add(list);
            }
            map.Add(new int[m + 2].Select((x) => -1).ToList());

            var queue = new Queue<int[]>();
            for (int i = 1; i < n + 1; ++i)
            {
                for (int j = 1; j < m + 1; ++j)
                {
                    if (map[i][j] == 1)
                    {
                        queue.Enqueue(new int[]{i, j});
                    }
                }
            }

            int spreadCnt = -1;

            while (queue.Count > 0)
            {
                spreadCnt++;

                var newTomato = new Queue<int[]>(queue);
                queue.Clear();

                while (newTomato.Count > 0)
                {
                    int[] nm = newTomato.Dequeue();
                    ripen(map, nm[0], nm[1], queue);
                }
            }
            
            for (int i = 1; i < n + 1; ++i)
            {
                for (int j = 1; j < m + 1; ++j)
                {
                    if (map[i][j] == 0)
                    {
                        spreadCnt = -1;
                        break;
                    }
                }
            }

            Console.Write(spreadCnt);
        }

        static void ripen(List<List<int>> map, int row, int col, Queue<int[]> newTomato)
        {
            var dx = new int[]{1, -1, 0, 0};
            var dy = new int[]{0, 0, 1, -1};

            for (int i = 0; i < 4; ++i)
            {
                if (map[row + dx[i]][col + dy[i]] == 0)
                {
                    map[row + dx[i]][col + dy[i]] = 1;
                    newTomato.Enqueue(new int[]{row + dx[i], col + dy[i]});
                }
            }
        }
    }
}
