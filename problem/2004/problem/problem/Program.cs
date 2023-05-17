namespace _2004
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split(" ").Select((str) => Convert.ToInt32(str)).ToArray();
            int n = nm[0], m = nm[1];

            int fiveCount = 0;
            int squareFive = 5;
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

            int twoCount = 0;
            int squareTwo = 2;
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
        }
    }
}