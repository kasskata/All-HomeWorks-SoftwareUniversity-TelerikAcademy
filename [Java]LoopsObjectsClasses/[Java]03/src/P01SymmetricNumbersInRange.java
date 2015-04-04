import java.util.Scanner;

public class P01SymmetricNumbersInRange {
    public static void main(String[] args) {
        Scanner inputSrc = new Scanner(System.in);

        int numberStart = Integer.parseInt(inputSrc.next());
        int numberFinish = Integer.parseInt(inputSrc.next());

        for (int i = numberStart; i < numberFinish; i++) {
            if ((i/100)%10 == i%10){
                System.out.println(i);
            }
        }
    }
}
