import java.util.Scanner;

public class P03PointInsideAFigure {
    public static void main( String[] args) {
        Scanner inputScn = new Scanner(System.in);
        double x = Double.parseDouble(inputScn.next());
        double y = Double.parseDouble(inputScn.next());
        //Big rectangle Area
        double aX = 12.5;
        double aY = 6;

        double bX = 22.5;
        double bY = 6;

        double cX = 22.5;
        double cY = 13.5;

        double dX = 12.5;
        double dY = 13.5;
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
        boolean isInsideDA = calcIsInsideTheEdge(dX, dY, aX, aY, x, y);
        //Calculate edges for the Hole
        boolean isNotInsideAB = calcIsInsideTheEdge(holeAX, holeAY, holeBX, holeBY, x, y);
        boolean isNotInsideBC = calcIsInsideTheEdge(holeBX, holeBY, holeCX, holeCY, x, y);
        boolean isNotInsideCD = calcIsInsideTheEdge(holeCX, holeCY, holeDX, holeDY, x, y);
        boolean isNotInsideDA = calcIsInsideTheEdge(holeDX, holeDY, holeAX, holeAY, x, y);


        //All check in 2 nested
        if (isInsideAB == true && isInsideBC == true && isInsideCD == true && isInsideDA == true) {
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
