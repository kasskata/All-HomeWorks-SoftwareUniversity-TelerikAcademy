import javax.lang.model.element.VariableElement;
import java.awt.*;
import java.util.Objects;
import java.util.Scanner;

/**
 * Created by kasskata on 12.5.2014 г..
 */
public class P01RectangleArea {
    public static void main(String[] args) {
        Scanner inputScan = new Scanner(System.in);


        int a = inputScan.nextInt();
        int b = inputScan.nextInt();
        System.out.println("Area: " + a * b);

    }
}
