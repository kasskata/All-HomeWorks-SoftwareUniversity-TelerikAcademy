import java.util.Scanner;

/**
 * Created by kasskata on 14.5.2014 г..
 */
public class P09PointInsideTheHouse {
    public static void main(String[] args) {
        Scanner inputScn = new Scanner(System.in);
        double x = Double.parseDouble(inputScn.next());
        double y = Double.parseDouble(inputScn.next());
        //Big rectangle Area
        double aX = 12.5;
        double aY = 8.5;

        double bX = 17.5;
        double bY = 3.5;

        double cX = 22.5;
        double cY = 8.5;

        double dX = 22.5;
        double dY = 13.5;

        double eX = 12.5;
        double eY = 13.5;

        //Hole Area
        double holeAX = 17.5;
        double holeAY = 8.5;

        double holeBX = 20;
        double holeBY = 8.5;

        double holeCX = 20;
        double holeCY = 13.5;

        double holeDX = 17.5;
        double holeDY = 13.5;

        //All Check goes in this boolean variable
        boolean resultBigQuadrant = false;

        //CAlCULATE edges Big Rectangle
        boolean isInsideAB = calcIsInsideTheEdge(aX, aY, bX, bY, x, y);
        boolean isInsideBC = calcIsInsideTheEdge(bX, bY, cX, cY, x, y);
        boolean isInsideCD = calcIsInsideTheEdge(cX, cY, dX, dY, x, y);
        boolean isInsideDE = calcIsInsideTheEdge(dX, dY, eX, eY, x, y);
        boolean isInsideEA = calcIsInsideTheEdge(eX, eY, aX, aY, x, y);
        //Calculate edges for the Hole
        boolean isNotInsideAB = calcIsInsideTheEdge(holeAX, holeAY, holeBX, holeBY, x, y);
        boolean isNotInsideBC = calcIsInsideTheEdge(holeBX, holeBY, holeCX, holeCY, x, y);
        boolean isNotInsideCD = calcIsInsideTheEdge(holeCX, holeCY, holeDX, holeDY, x, y);
        boolean isNotInsideDA = calcIsInsideTheEdge(holeDX, holeDY, holeAX, holeAY, x, y);



        //All check in 2 nested
        if (isInsideAB == true && isInsideBC == true && isInsideCD == true && isInsideDE == true && isInsideEA == true) {
            resultBigQuadrant = true;
            System.out.println("inside Big");
        }
        if (isNotInsideAB == true && isNotInsideBC == true && isNotInsideCD == true && isNotInsideDA == true) {
            resultBigQuadrant = false;
            System.out.println("inside Small");
        }
        System.out.println(resultBigQuadrant ? "Inside" : "Outside");
    }
    //Cant do x & y outside the main method C# like !?
    public static boolean calcIsInsideTheEdge(double aX, double aY, double bX, double bY, double x, double y) {
        boolean isInside = false;

        double a = -(bY - aY);
        double b = bX - aX;
        double c = -(a * aX + b * aY);
        double D = a * x + b * y + c;
        if (D >= 0) {
            isInside = true;
        }

        return isInside;
    }
}
