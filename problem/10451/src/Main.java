import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class Main {
	public static void main(String[] args) throws Exception {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

		int testCnt = Integer.parseInt(br.readLine());
		
		while (testCnt-- != 0) {
			int n = Integer.parseInt(br.readLine());
			int[] edge = new int[n];
			int[] fromNodes = new int[n];
			
			StringTokenizer st = new StringTokenizer(br.readLine(), " ");
			
			for (int i = 0; i < n; ++i) {
				edge[i] = Integer.parseInt(st.nextToken());
				fromNodes[i] = i;
			}
			
			int answer = 0;
			for (int i = 0; i < n; ++i) {
				int from = i;
				
				while (true) {
					int to = edge[from] - 1;
					
					if (fromNodes[to] == i) {
						answer++;
						break;
					}
					
					if (fromNodes[to] != to) {
						break;
					}
					
					fromNodes[to] = i;
					
					from = to;
				}
			}
			
			System.out.println(answer);
		}
	}
}
