import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Arrays;

public class Main {
	static public void main(String[] args) throws Exception {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String[] nk = br.readLine().split(" ");
		int n = Integer.parseInt(nk[0]);
		int k = Integer.parseInt(nk[1]);
		int[] nums = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();
		
		int[] sumArr = new int[n - (k - 1)];
		
		for (int i = 0; i < k; ++i) {
			sumArr[0] += nums[i];
		}
		
		int max = sumArr[0];
		for (int i = 1; i < n - (k - 1); ++i) {
			sumArr[i] = sumArr[i - 1] - nums[i - 1] + nums[i + (k - 1)];
			if (sumArr[i] > max) {
				max = sumArr[i];
			}
		}
		
		System.out.println(max);
	}
}
