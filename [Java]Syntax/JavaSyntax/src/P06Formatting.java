import java.util.Scanner;

public class P06Formatting {
    public static void main(String[] args) {
        Scanner inputScn = new Scanner(System.in);
        double[] numbers = new double[3];

        numbers[0] = Double.parseDouble(inputScn.next());
        String binRepr = String.format("%10s", Integer.toBinaryString((int)numbers[0])).replace(' ', '0');
        numbers[1] = Double.parseDouble(inputScn.next());
        numbers[2] = Double.parseDouble(inputScn.next());


        System.out.printf("|%-10X|%s|%10.2f|%-10.3f|",(int)numbers[0],binRepr,numbers[1],numbers[2]);

    }
}
