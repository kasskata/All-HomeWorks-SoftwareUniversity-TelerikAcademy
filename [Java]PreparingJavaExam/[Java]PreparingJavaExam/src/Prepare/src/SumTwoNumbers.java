import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {
        System.out.println("Enter 2 numbers: ");

        Scanner input = new Scanner(System.in);

        System.out.print("a = ");
        int a = input.nextInt();
        System.out.print("b = ");
        int b = input.nextInt();

        System.out.println("Sum a + b = " + (a + b));
    }
}

