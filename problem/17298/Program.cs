using System;
using System.Collections.Generic;
using System.Text;

namespace _17298
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var numList = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
            var answer = new List<int>(new int[n]);

            Stack<int> stack = new Stack<int>();
            stack.Push(0);

            for (int i = 1; i < n; ++i)
            {
                while (stack.Count != 0)
                {
                    int prevIdx = stack.Peek();
                    if (numList[prevIdx] >= numList[i])
                    {
                        stack.Push(i);
                        break;
                    }

                    answer[prevIdx] = numList[i];
                    stack.Pop();
                }
                
                stack.Push(i);
            }

            while (stack.Count != 0)
            {
                answer[stack.Pop()] = -1;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; ++i)
            {
                sb.Append(answer[i] + " ");
            }
            
            Console.WriteLine(sb.ToString());
        }   
    }
}