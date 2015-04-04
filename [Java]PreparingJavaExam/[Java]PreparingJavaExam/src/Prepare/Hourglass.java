package Prepare;

import java.util.Arrays;
import java.util.Scanner;

public class Hourglass {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        for (int i = 0; i < n/2+1; i++) {
            System.out.print(new_String('.', i));
            System.out.print(new_String('*', n - i * 2));
            System.out.println(new_String('.', i));
        }
        int dots=n/2;
        int asterix = -1;
        for (int i = 0; i < n/2; i++) {
            System.out.print(new_String('.',dots-1));
            asterix+=2;
            System.out.print(new_String('*',asterix+2));
            System.out.println(new_String('.',dots-1));
            dots-=1;
        }
    }
    public static String new_String(char charToFill, int length) {
        if (length > 0) {
            char[] array = new char[length];
            Arrays.fill(array, charToFill);
            return new String(array);
        }
        return "";
    }
}
