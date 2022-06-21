using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1874
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<int> stack = new Stack<int>();
            int nextNum = 1;
            
            for (int i = 1; i <= n; ++i)
            {
                int outNum = Convert.ToInt32(Console.ReadLine());

                while (stack.Count <= 0 || stack.Peek() < outNum)
                {
                    stack.Push(nextNum++);
                    sb.Append("+\n");
                }

                if (stack.Peek() != outNum)
                {
                    sb.Clear();
                    sb.Append("NO");
                    break;
                }

                stack.Pop();
                sb.Append("-\n");
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}