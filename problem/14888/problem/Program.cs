namespace _14888
{
    class Program
    {
        private static int max = -1000000000;
        private static int min = 1000000000;
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(" ").Select(num => Convert.ToInt32(num)).ToArray();
            int[] operations = Console.ReadLine().Split(" ").Select(num => Convert.ToInt32(num)).ToArray();

            dfs(nums, operations, nums[0], 1);
            
            Console.WriteLine(max);
            Console.WriteLine(min);
        }

        static void dfs(int[] nums, int[] operations, int result, int idx)
        {
            if (idx >= nums.Length)
            {
                max = Math.Max(max, result);
                min = Math.Min(min, result);
                return;
            }

            if (operations[0] > 0)
            {
                operations[0]--;
                dfs(nums, operations, result + nums[idx], idx + 1);
                operations[0]++;
            }

            if (operations[1] > 0)
            {
                operations[1]--;
                dfs(nums, operations, result - nums[idx], idx + 1);
                operations[1]++;
            }

            if (operations[2] > 0)
            {
                operations[2]--;
                dfs(nums, operations, result * nums[idx], idx + 1);
                operations[2]++;
            }

            if (operations[3] > 0)
            {
                operations[3]--;
                dfs(nums, operations, result / nums[idx], idx + 1);
                operations[3]++;
            }
        }
    }
}