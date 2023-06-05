namespace _2156
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] wine = new int[n];
            int[] maxWine = new int[n];

            for (int i = 0; i < n; ++i)
            {
                wine[i] = Convert.ToInt32(Console.ReadLine());
            }

            maxWine[0] = wine[0];
            int max = maxWine[0];

            if (n > 1)
            {
                maxWine[1] = wine[0] + wine[1];
                max = maxWine[1];
            }
            
            if (n > 2)
            {
                maxWine[2] = Math.Max(Math.Max(wine[1] + wine[2], maxWine[0] + wine[2]), maxWine[1]);
                max = Math.Max(max, maxWine[2]);
            }

            for (int i = 3; i < n; ++i)
            {
                maxWine[i] = Math.Max(Math.Max(maxWine[i - 2] + wine[i], maxWine[i - 3] + wine[i - 1] + wine[i]), maxWine[i - 1]);
                max = Math.Max(max, maxWine[i]);
            }

            Console.WriteLine(max);
        }
    }
}