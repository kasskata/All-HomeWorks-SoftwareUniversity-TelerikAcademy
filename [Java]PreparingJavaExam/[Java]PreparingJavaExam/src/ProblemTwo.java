import java.util.Scanner;

public class ProblemTwo {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] numbers = new int [n];
        StringBuilder test = new StringBuilder();
        for (int i = 0; i < n; i++) {
            numbers[i] = in.nextInt();
        }
        for (int a = 0; a < numbers.length; a++) {
            for (int b = 0; b < numbers.length; b++) {
                for (int c = 0; c < numbers.length; c++) {
                    if (numbers[a] <= numbers[b]) {
                        if (numbers[a] * numbers[a] + numbers[b] * numbers[b] == numbers[c] * numbers[c]){
                            System.out.println(numbers[a]+"*"+numbers[a]+" + "+numbers[b]+"*"+numbers[b]+" = "+numbers[c]+"*"+numbers[c]);
                            test.append("*");
                        }
                    }
                }
            }
        }
        if (test.length() == 0) {
            System.out.print("No");
        }
    }
}
