import java.util.ArrayList;
import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		int n, m;
		
		Scanner sc = new Scanner(System.in);
		n = sc.nextInt();
		m = sc.nextInt();
		ArrayList<Integer> q = new ArrayList<>();
		for (int i = 0; i < n; ++i) {
			q.add(i + 1);
		}
		ArrayList<Integer> needNumList = new ArrayList<>();
		for (int i = 0; i < m; ++i) {
			needNumList.add(sc.nextInt());
		}
		
		int answer = 0;
		int curIdx = 0;
		for (int i = 0; i < m; ++i)
		{
			int idx = q.indexOf(needNumList.get(i));
			
			int distance = Math.abs(curIdx - idx);
			int distance2 = q.size() - Math.max(curIdx, idx) + Math.min(curIdx, idx);
			answer += Math.min(distance, distance2);
			
			q.remove(idx);
			
			curIdx = idx;
			if (curIdx >= q.size()) {
				curIdx = 0;
			}
		}
		
		System.out.println(answer);
	}
}
