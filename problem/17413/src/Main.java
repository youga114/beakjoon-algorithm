import java.util.Scanner;
import java.lang.StringBuilder;

public class Main {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String str = sc.nextLine();
		
		int prevIdx = 0;
		boolean tagFlag = false;
		for (int i = 0; i < str.length(); ++i) {
			char curChar = str.charAt(i);
			
			if (curChar == '>') {
				tagFlag = false;
				prevIdx = i + 1;
			}
			
			if (tagFlag == true) {
				continue;
			}
			
			if (curChar == '<') {
				tagFlag = true;
				
				StringBuilder sb = new StringBuilder();
				str = str.substring(0, prevIdx) + sb.append(str.substring(prevIdx, i)).reverse().toString() + str.substring(i);
				
				continue;
			}
			
			if (curChar == ' ') {
				StringBuilder sb = new StringBuilder();
				str = str.substring(0, prevIdx) + sb.append(str.substring(prevIdx, i)).reverse().toString() + str.substring(i);
				
				prevIdx = i + 1;
			}
		}
		
		StringBuilder sb = new StringBuilder();
		str = str.substring(0, prevIdx) + sb.append(str.substring(prevIdx, str.length())).reverse().toString(); 
		
		System.out.println(str);
	}
}
