using System;
using System.Collections.Generic;
using System.Text;

namespace _12865
{
    class Program
    {
        static void Main(string[] args)
        {
            var nk = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
            int n = nk[0], k = nk[1];

            var bag = new List<int>(new int[k + 1]);
            for (int i = 1; i < k + 1; ++i)
            {
                bag[i] = -1;
            }
            
            int max = 0;
            for (int i = 0; i < n; ++i)
            {
                var weightAndValue = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
                int weight = weightAndValue[0], value = weightAndValue[1];

                for (int j = k; j >= weight; --j)
                {
                    if (bag[j - weight] + value > bag[j] )
                    {
                        bag[j] = bag[j - weight] + value;
                        if (bag[j] > max)
                        {
                            max = bag[j];
                        }
                    }
                }
            }
            
            Console.WriteLine(max);
        }
    }
}