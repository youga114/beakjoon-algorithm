namespace _1676
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int zeroCount = 0;

            int twoCount = 0, fiveCount = 0;
            for (int i = 1; i < n + 1; ++i)
            {
                int num = i;
                while (num % 2 == 0)
                {
                    num /= 2;
                    twoCount++;
                }

                while (num % 5 == 0)
                {
                    num /= 5;
                    fiveCount++;
                }
            }
            
            Console.WriteLine(Math.Min(twoCount, fiveCount));
        }
    }
}