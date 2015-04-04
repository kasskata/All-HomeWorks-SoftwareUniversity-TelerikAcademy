package Prepare;

import java.math.BigInteger;
import java.util.Scanner;

public class Tribonachi {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        BigInteger f = new BigInteger(in.next().replaceAll(",", ""));
        BigInteger s = new BigInteger(in.next().replaceAll(",", ""));
        BigInteger t = new BigInteger(in.next().replaceAll(",", ""));
        long n = Long.parseLong(in.next());
        for (int i = 1; i <= n-3; i++) {
            BigInteger test = BigInteger.valueOf(i);
            BigInteger temp = t;
            t = f.add(s).add(t);
            f=s;
            s=temp;
        }
        System.out.println(t);


    }
}
