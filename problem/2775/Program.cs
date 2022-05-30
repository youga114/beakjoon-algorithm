using System;
using System.Collections.Generic;

namespace _2775
{
    class Program
    {
        static void Main(string[] args)
        {
            var apartment = new List<List<int>>();

            for (int i = 0; i < 15; ++i)
            {
                apartment.Add(new List<int>(new int[15]));
                apartment[0][i] = i;
            }

            for (int i = 1; i <= 14; ++i)
            {
                for (int j = 1; j <= 14; ++j)
                {
                    for (int k = 1; k <= j; ++k)
                    {
                        apartment[i][j] += apartment[i - 1][k];
                    }
                }
            }
            
            int testCnt = Convert.ToInt32(Console.ReadLine());
            while (testCnt-- != 0)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(apartment[k][n]);
            }
        }
    }
}