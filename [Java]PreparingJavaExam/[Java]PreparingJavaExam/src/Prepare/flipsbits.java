package Prepare;

import java.math.BigInteger;
import java.util.Scanner;

public class flipsbits {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        BigInteger number = new BigInteger(in.next().replaceAll(",", ""));
        StringBuilder insertzeroes = new StringBuilder();

        if (number.toString(2).length()< 64)
        {
            for (int i = number.toString(2).length(); i < 64; i++) {
                insertzeroes.append("0");
            }
        }
        String binary= insertzeroes.toString().concat(number.toString(2));
        StringBuilder newBinary = new StringBuilder();
        int i = 0;
        for (; i <= binary.length()-2; i++) {
           if (i < binary.length()-2) {
               if (binary.charAt(i) == binary.charAt(i + 1) &&
                       binary.charAt(i + 1) == binary.charAt(i + 2)) {
                   if (binary.charAt(i) == '1') {
                       newBinary.append('0');
                       newBinary.append('0');
                       newBinary.append('0');
                       i += 2;

                   } else {
                       newBinary.append('1');
                       newBinary.append('1');
                       newBinary.append('1');
                       i += 2;
                   }
               } else {
                   newBinary.append(binary.charAt(i));
               }
           }
           else if (i >= binary.length()-2){
               newBinary.append(binary.charAt(binary.length()-2));
               newBinary.append(binary.charAt(binary.length()-1));
               break;
           }
        }
        number = new  BigInteger(newBinary.toString(),2);
        System.out.println(number);
    }
}
