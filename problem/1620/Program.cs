using System;
using System.Collections.Generic;
using System.Text;

namespace _1620
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nm = Console.ReadLine().Split(" ").ToList();
            int n = Convert.ToInt32(nm[0]), m = Convert.ToInt32(nm[1]);

            Dictionary<string, int> pocketmonsStr = new Dictionary<string, int>();
            Dictionary<int, string> pocketmonsInt = new Dictionary<int, string>();
            for (int i = 0; i < n; ++i)
            {
                string pocketmon = Console.ReadLine();
                pocketmonsStr.Add(pocketmon, i + 1);
                pocketmonsInt.Add(i + 1, pocketmon);
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < m; ++i)
            {
                string question = Console.ReadLine();
                if (question[0] == '1' ||
                    question[0] == '2' ||
                    question[0] == '3' ||
                    question[0] == '4' ||
                    question[0] == '5' ||
                    question[0] == '6' ||
                    question[0] == '7' ||
                    question[0] == '8' ||
                    question[0] == '9')
                {
                    sb.Append(pocketmonsInt[Convert.ToInt32(question)] + "\n");
                }
                else
                {
                    sb.Append(pocketmonsStr[question] + "\n");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}