using System;
using System.Collections.Generic;
using System.Text;

namespace _10815
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var haveCards = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
            
            haveCards.Sort();
            
            int m = Convert.ToInt32(Console.ReadLine());
            
            var cards = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < m; ++i)
            {
                if (haveCards.BinarySearch(cards[i]) < 0)
                {
                    sb.Append(0 + " ");
                }
                else
                {
                    sb.Append(1 + " ");
                }
            }

            Console.Write(sb.ToString());
        }
    }
}