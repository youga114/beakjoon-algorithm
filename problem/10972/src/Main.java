import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Arrays;

public class Main {
	static int isAnswerWord = 0;
	
	static public void main(String[] args) throws Exception {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int n = Integer.parseInt(br.readLine());
		int[] prevWord = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();
		
		int ascIdx = -1;
		for (int i = n - 1; i > 0; --i) {
			if (prevWord[i] > prevWord[i - 1]) {
				ascIdx = i;
				break;
			}
		}
		
		if (ascIdx == -1) {
			System.out.println(-1);
			return;
		}
		
		int[] answerFirstWord = Arrays.copyOfRange(prevWord, 0, ascIdx);
		int[] answerLastWord = Arrays.copyOfRange(prevWord, ascIdx, n);
		
		int min = answerLastWord[0];
		int minIdx = 0;
		for (int i = 1; i < answerLastWord.length; ++i)
		{
			if (answerLastWord[i] > answerFirstWord[answerFirstWord.length - 1] && answerLastWord[i] < min) {
				min = answerLastWord[i];
				minIdx = i;
			}
		}

		answerLastWord[minIdx] = answerFirstWord[answerFirstWord.length - 1];
		answerFirstWord[answerFirstWord.length - 1] = min;
		
		Arrays.sort(answerLastWord);
		
		StringBuilder sb = new StringBuilder();
		for (int i = 0 ; i < answerFirstWord.length; ++i) {
			sb.append(answerFirstWord[i] + " ");
		}
		for (int i = 0 ; i < answerLastWord.length; ++i) {
			sb.append(answerLastWord[i] + " ");
		}
		
		System.out.println(sb.toString());
	}
}
