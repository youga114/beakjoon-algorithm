import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;

public class Main {
	static public void main(String[] args) throws Exception {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int n = Integer.parseInt(br.readLine());
		int[] nums = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();
		
		int curSum = nums[0];
		int max = nums[0];
		
		for (int i = 1; i < n; ++i) {
			if (nums[i] + curSum > 0 && curSum > 0) {
				curSum += nums[i];
			}
			else {
				curSum = nums[i];
			}
			
			max = Integer.max(max, curSum);
		}
		
		System.out.println(max);
	}
}