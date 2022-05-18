using System;
using System.Collections.Generic;
using System.Linq;

namespace _11047
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, answer = 0;

            var nk = Console.ReadLine().Split(" ").ToList();

            n = Convert.ToInt32(nk[0]);
            k = Convert.ToInt32(nk[1]);

            var coins = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                coins.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = coins.Count - 1; i >= 0; --i)
            {
                while (k >= coins[i])
                {
                    k -= coins[i];
                    answer++;
                }
            }
            
            Console.WriteLine(answer);
        }
    }
}
