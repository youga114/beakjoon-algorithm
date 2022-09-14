import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Arrays;

public class Main {
	public static void main(String[] args) throws Exception {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int n = Integer.parseInt(br.readLine());
		int[] distance = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();
		int[] gasStation = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();
		
		int min = gasStation[0];
		long sumDistance = distance[0];
		long answer = 0;
		for (int i = 1; i < n - 1; ++i) {
			if (min > gasStation[i]) {
				answer += min * sumDistance;
				sumDistance = 0;
				min = gasStation[i];
			}
			
			sumDistance += distance[i];
		}

		answer += min * sumDistance;
		
		System.out.println(answer);
	}
}