import java.util.Scanner;

public class P05AngleUnitConverter {
    public static void main(String[] args) {
        Scanner inputScn = new Scanner(System.in);
        int n = Integer.parseInt(inputScn.next());
        double tempNumber;

        for (int i = 0; i < n; i++) {
            tempNumber = Integer.parseInt(inputScn.next());
            String tempType = inputScn.next();
            if (tempType.toLowerCase().equals("deg")) {
                tempNumber = tempNumber*(Math.PI/180);
                System.out.printf("%6f", tempNumber);
                System.out.println();
            }
            else if(tempType.toLowerCase().equals("rad"))
            {
                tempNumber = tempNumber*(180/Math.PI);
                System.out.printf("%6f", tempNumber);
                System.out.println();
            }
        }
    }
}
