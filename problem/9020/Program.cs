using System;
using System.Collections.Generic;
using System.Text;

namespace _9020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var isPrime = new List<bool>(new bool[10001]);
            
            for (int i = 2; i < 10001; ++i)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i < 10001; ++i)
            {
                if (isPrime[i] == true)
                {
                    for (int j = i * i; j < 10001; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            for (int i = 0; i < n; ++i)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                int leftNum = num / 2, rightNum = num / 2;

                while (isPrime[leftNum] == false || isPrime[rightNum] == false)
                {
                    leftNum--;
                    rightNum++;
                }
                
                Console.WriteLine(leftNum + " " + rightNum);
            }
        }   
    }
}