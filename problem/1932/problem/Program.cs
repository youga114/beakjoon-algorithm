namespace _1932
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] tree = new int[n][];
            int max = 0;

            for (int i = 0; i < n; ++i)
            {
                int[] nodes = Console.ReadLine().Split(" ").Select((s => Convert.ToInt32(s))).ToArray();
                tree[i] = nodes;
            }

            for (int i = 1; i < tree.Length; ++i)
            {
                tree[i][0] += tree[i - 1][0];
                
                for (int j = 1; j < tree[i].Length - 1; ++j)
                {
                    tree[i][j] += Math.Max(tree[i - 1][j - 1], tree[i - 1][j]);
                }
                
                tree[i][tree[i].Length - 1] += tree[i - 1][tree[i - 1].Length - 1];
            }

            for (int i = 0; i < tree[n - 1].Length; ++i)
            {
                max = Math.Max(tree[n - 1][i], max);
            }
            
            Console.WriteLine(max);
        }
    }
}