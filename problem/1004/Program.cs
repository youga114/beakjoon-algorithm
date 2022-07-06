using System;
using System.Collections.Generic;
using System.Text;

namespace _1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int testNum = Convert.ToInt32(Console.ReadLine());
            
            for (int testCnt = 0; testCnt < testNum; testCnt++)
            {
                var xy = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
                int x1 = xy[0], y1 = xy[1], x2 = xy[2], y2 = xy[3];
                
                int n = Convert.ToInt32(Console.ReadLine());

                int answer = 0;
                for (int i = 0; i < n; ++i)
                {
                    var circles = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
                    int circleX = circles[0], circleY = circles[1], r = circles[2];

                    double distance1 = Math.Sqrt(Math.Pow(x1 - circleX, 2) + Math.Pow(y1 - circleY, 2));
                    double distance2 = Math.Sqrt(Math.Pow(x2 - circleX, 2) + Math.Pow(y2 - circleY, 2));

                    if (r > distance1 && r < distance2 || r < distance1 && r > distance2)
                    {
                        answer++;
                    }
                }
                
                Console.WriteLine(answer);
            }
        }   
    }
}