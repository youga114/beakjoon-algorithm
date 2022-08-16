import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		int jimin = sc.nextInt();
		int hansu = sc.nextInt();
		
		if (jimin > hansu) {
			int temp = jimin;
			jimin = hansu;
			hansu = temp;
		}
		
		while(true) {
			int twoExp = 1;
			int cnt = 1;
			while (twoExp * 2 < hansu) {
				twoExp *= 2;
				cnt++;
			}
			
			if (jimin <= twoExp) {
				System.out.println(cnt);
				return;
			}
			
			jimin -= twoExp;
			hansu -= twoExp;
		}
		
	}
}
