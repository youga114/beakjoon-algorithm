using System;
using System.Collections.Generic;

namespace _1158
{
    class Program
    {
        static void Main(string[] args)
        {
            string nk = Console.ReadLine();
            int n = Convert.ToInt32(nk.Split()[0]);
            int k = Convert.ToInt32(nk.Split()[1]);

            Console.Write("<");

            var isRemoved = new List<bool>(new bool[n + 1]);
            isRemoved[0] = true;

            int curIdx = 0;
            int printCnt = n;

            while (printCnt > 0)
            {
                int jump = k;
                while (jump > 0)
                {
                    curIdx++;
                    if (curIdx > n) 
                    {
                        curIdx = 1;
                    }

                    if (isRemoved[curIdx] == false)
                    {
                        jump--;
                    }
                }

                isRemoved[curIdx] = true;
                Console.Write(curIdx);

                printCnt--;
                if (printCnt > 0) 
                {
                    Console.Write(", ");
                }
            }

            Console.Write(">");
        }
    }
}
