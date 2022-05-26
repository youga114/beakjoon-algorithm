using System;
using System.Collections.Generic;
using System.Linq;

namespace _10757
{
    class Program
    {
        static void Main(string[] args)
        {
            var ab = Console.ReadLine().Split(" ").ToList();
            string a = ab[0], b = ab[1];

            int maxCnt = 0;
            if (a.Length >= b.Length)
            {
                maxCnt = a.Length;
            }
            else
            {
                maxCnt = b.Length;
            }

            int nextNum = 0;
            string answer = "";
            for (int i = 0; i < maxCnt; ++i)
            {
                char aChar = '0', bChar = '0';
                if (a.Length - i - 1 >= 0)
                {
                    aChar = a[a.Length - i - 1];
                }

                if (b.Length - i - 1 >= 0)
                {
                    bChar = b[b.Length - i - 1];
                }

                int sum = Convert.ToInt32(aChar.ToString()) + Convert.ToInt32(bChar.ToString()) + nextNum;
                if (sum >= 10)
                {
                    nextNum = 1;
                    sum -= 10;
                }
                else
                {
                    nextNum = 0;
                }

                answer = sum.ToString() + answer;
            }

            if (nextNum == 1)
            {
                answer = "1" + answer;
            }

            Console.WriteLine(answer);
        }
    }
}
