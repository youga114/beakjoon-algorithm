using System;
using System.Collections.Generic;
using System.Text;

namespace _1966
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCnt = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < testCnt; ++t)
            {
                var nm = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
                int n = nm[0], m = nm[1];

                var nums = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
                var numCnt = new List<int>(new int[10]);

                for (int i = 0; i < n; ++i)
                {
                    numCnt[nums[i]] += 1;
                }

                int maxNum = 9;

                for (int i = 9; i > 0; --i)
                {
                    if (numCnt[i] != 0)
                    {
                        maxNum = i;
                        break;
                    }
                }

                int idx = 0, answer = 1;
                while (idx != m || maxNum != nums[m])
                {
                    if (nums[idx] == maxNum)
                    {
                        nums[idx] = -1;
                        answer++;
                        numCnt[maxNum] -= 1;

                        if (numCnt[maxNum] == 0)
                        {
                            for (int i = maxNum - 1; i > 0; --i)
                            {
                                if (numCnt[i] != 0)
                                {
                                    maxNum = i;
                                    break;
                                }
                            }
                        }
                    }
                    
                    idx++;
                    if (idx >= n)
                    {
                        idx = 0;
                    }
                }
                
                Console.WriteLine(answer);
            }
        }
    }
}