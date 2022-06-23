using System;
using System.Collections.Generic;
using System.Text;

namespace _10773
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; ++i)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(num);
                }
            }

            int answer = 0;
            foreach (var i in stack)
            {
                answer += i;
            }
            
            Console.WriteLine(answer);
        }
    }
}