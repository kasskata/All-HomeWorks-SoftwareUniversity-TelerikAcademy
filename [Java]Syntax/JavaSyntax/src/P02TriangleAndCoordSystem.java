
public class P02TriangleAndCoordSystem {
    public static void main(String[] args) {
        //не се чуди.Задачата е леко променена от инпута даден в задачата
        //но така дава триъгълник по линии което е по-сложното.Нарочно е така
        //за да видим как става по сложното намиране на триъгълник.

        int x1 = 3;
        int y1 = 4;

        int x2 = 9;
        int y2 = 13;

        int x3 = 9;
        int y3 = 13;

        int x4 = 12;
        int y4 = 6;

        int x5 = 12;
        int y5 = 6;

        int x6 = 3;
        int y6 = 4;

        int line1 = InitilizeLines(x1, y1, x2, y2);
        int line2 = InitilizeLines(x3, y3, x4, y4);
        int line3 = InitilizeLines(x5, y5, x6, y6);

        boolean triangle = isTriangle(line1, line2, line3);

        System.out.println("do we have triangle?:" + triangle);
    }

    //methods
    public static int InitilizeLines(int x1, int y1, int x2, int y2) {

        return (int) Math.sqrt(Math.pow((x1 - x2), 2) + (Math.pow((y1 - y2), 2)));
    }

    public static boolean isTriangle(int line1, int line2, int line3) {
        if (line1 + line2 > line3 && line2 + line3 > line1 && line3 + line1 > line2) {
            return true;
        } else {
            return false;
        }
    }
}
