import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by kasskata on 14.5.2014 г..
 */
public class P04SmallestNumber {
    public static void main(String[] args) {
        double[] batman = new double[3];
        Scanner inputScn = new Scanner(System.in);

        batman[0] = Double.parseDouble(inputScn.next());
        batman[1] = Double.parseDouble(inputScn.next());
        batman[2] = Double.parseDouble(inputScn.next());

        Arrays.sort(batman);
        System.out.println(batman[0]);
    }
}
