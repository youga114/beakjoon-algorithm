using System;
using System.Collections.Generic;
using System.Text;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(" ").Select((x) => Convert.ToInt32(x)).ToList();
            int n = nm[0], m = nm[1], minNum = 32;
            var chess = new List<List<char>>();
            
            for (int i = 0; i < n; ++i)
            {
                chess.Add(Console.ReadLine().ToList());
            }

            for (int i = 0; i <= n - 8; ++i)
            {
                for (int j = 0; j <= m - 8; ++j)
                {
                    int fixCnt = FixCnt(chess, i, j);

                    if (fixCnt < minNum)
                    {
                        minNum = fixCnt;
                    }
                }
            }
            
            Console.WriteLine(minNum);
        }

        static int FixCnt(List<List<char>> chess, int row, int col)
        {
            int changeCnt = 0;
            
            for (int i = 0; i < 8; i += 2)
            {
                for (int j = 0; j < 8; j += 2)
                {
                    if (chess[row + i][col + j] == 'W')
                    {
                        changeCnt++;
                    }
                    if (chess[row + i][col + j + 1] == 'B')
                    {
                        changeCnt++;
                    }
                    if (chess[row + i + 1][col + j] == 'B')
                    {
                        changeCnt++;
                    }
                    if (chess[row + i + 1][col + j + 1] == 'W')
                    {
                        changeCnt++;
                    }
                }
            }

            if (changeCnt > 32)
            {
                return 64 - changeCnt;
            }

            return changeCnt;
        }
    }
}