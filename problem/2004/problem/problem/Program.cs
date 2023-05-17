namespace _2004
{
    class Program
    {
        static int Main(string[] args)
        {
            long[] nm = Console.ReadLine().Split(" ").Select((str) => Convert.ToInt64(str)).ToArray();
            long n = nm[0], m = nm[1];
            long fiveCount = 0;
            long twoCount = 0;
            long squareFive = 5;
            long squareTwo = 2;
            
            while (squareFive <= n)
            {
                fiveCount += n / squareFive;
                squareFive *= 5;
            }

            squareFive = 5;
            while (squareFive <= m)
            {
                fiveCount -= m / squareFive;
                squareFive *= 5;
            }

            squareFive = 5;
            while (squareFive <= n - m)
            {
                fiveCount -= (n - m) / squareFive;
                squareFive *= 5;
            }

            while (squareTwo <= n)
            {
                twoCount += n / squareTwo;
                squareTwo *= 2;
            }

            squareTwo = 2;
            while (squareTwo <= m)
            {
                twoCount -= m / squareTwo;
                squareTwo *= 2;
            }

            squareTwo = 2;
            while (squareTwo <= n - m)
            {
                twoCount -= (n - m) / squareTwo;
                squareTwo *= 2;
            }
            
            Console.WriteLine(Math.Min(fiveCount, twoCount));

            return 0;
        }
    }
}