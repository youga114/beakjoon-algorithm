using System;
using System.Collections.Generic;

namespace _7568
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var all = new List<List<int>>();

            for (int i = 0; i < n; ++i)
            {
                var tempList = Console.ReadLine().Split(' ').Select((x) => Convert.ToInt32(x)).ToList();
                all.Add(tempList);
            }

            var rank = new List<int>(new int[n]);
            for (int i = 0; i < n; ++i)
            {
                rank[i] = 1;
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (all[i][0] > all[j][0] && all[i][1] > all[j][1])
                    {
                        rank[j]++;
                    }
                }
            }

            for (int i = 0; i < n; ++i)
            {
                Console.Write(rank[i] + " ");
            }
        }
    }
}