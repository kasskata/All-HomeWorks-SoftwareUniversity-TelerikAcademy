import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class ProblemThree {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int max=0;
        String[] text = (in.nextLine().split("[\\D+]+"));

        List<String> numbers = new ArrayList<>();
        for (int i = 1; i < text.length-1; i+=2) {
            numbers.add(text[i] +","+ text[i + 1]);
        }
        for (int i = 0; i < numbers.size()-2; i++) {
            String[] a = numbers.get(i).split(",");
            String[] b = numbers.get(i+1).split(",");
            String[] c = numbers.get(i+2).split(",");
            int sum = Integer.parseInt(a[0])*Integer.parseInt(a[1])+Integer.parseInt(b[0])*Integer.parseInt(b[1])+Integer.parseInt(c[0])*Integer.parseInt(c[1]);
           if (max < sum){
               max=sum;
           }
        }
        System.out.println(max);
    }
}
