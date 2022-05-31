using System;
using System.Collections.Generic;

namespace _2164
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var allCard = new List<bool>(new bool[n + 1]);

            int idx = 2, prevIdx = 1, cnt = 0;
            allCard[1] = true;
            if (idx > n)
            {
                idx = 1;
            }

            while (idx != prevIdx)
            {
                if (allCard[idx] == false)
                {
                    cnt++;
                    prevIdx = idx;
                }

                if (cnt == 2)
                {
                    cnt = 0;
                    allCard[idx] = true;
                }
                
                idx++;
                if (idx > n)
                {
                    idx = 1;
                }
            }
            
            Console.WriteLine(idx);
        }
    }
}