import java.util.Scanner;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;

public class Main {
	public static void main(String[] args) {
		int n, m;
		
		Scanner sc = new Scanner(System.in);
		n = sc.nextInt();
		m = sc.nextInt();
		sc.nextLine();
		
		ArrayList<String> checkList = new ArrayList<>();
		for (int i = 0; i < n; ++i) {
			checkList.add(sc.nextLine());
		}

		HashMap<String, Integer> map = new HashMap<>();
		for (int i = 0; i < m; ++i) {
			String key = sc.nextLine();
			if (map.containsKey(key))
			{
				map.put(key, map.get(key) + 1);
			}
			else {
				map.put(key, 1);
			}
		}
		
		int answer = 0;
		for (int i = 0; i < n; ++i) {
			String key = checkList.get(i);
			if (map.containsKey(key))
			{
				answer += map.get(key);
			}
		}
		
		System.out.println(answer);
	}
}
