import java.util.Scanner;
public class P05Hex {
    public static void main(String[] args) throws Exception {
        Scanner inputScn = new Scanner(System.in);
        int number = new Integer(0);
            number = Integer.parseInt(inputScn.next());
            System.out.printf("%1$H", number);
    }
}
