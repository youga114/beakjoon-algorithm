using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10816
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());

            var allNum = Console.ReadLine().Split(" ");

            var numCnt = new int[20000001];

            foreach(var num in allNum)
            {
                numCnt[Convert.ToInt32(num) + 10000000]++;
            }

            int receivedCnt = Convert.ToInt32(Console.ReadLine());

            var receivedNum = Console.ReadLine().Split(" ");

            StringBuilder stringBuilder = new StringBuilder();
            foreach(var num in receivedNum)
            {
                stringBuilder.Append(numCnt[Convert.ToInt32(num) + 10000000] + " ");
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}