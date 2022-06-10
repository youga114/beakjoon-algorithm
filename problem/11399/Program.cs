using System;
using System.Collections.Generic;

namespace _11399
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var waiting = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
            int answer = 0;
            
            waiting.Sort();
            for (int i = 0; i < n; ++i)
            {
                answer += waiting[i] * (n - i);
            }
            
            Console.WriteLine(answer);
        }
    }
}