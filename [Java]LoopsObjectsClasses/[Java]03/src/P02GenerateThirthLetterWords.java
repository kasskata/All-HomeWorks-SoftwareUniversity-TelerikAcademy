//        Write a program to generate and print all 3-letter words consisting of given set of characters. For example
// if we have the characters 'a' and 'b', all possible words will be "aaa", "aab", "aba", "abb", "baa", "bab", "bba" and
// "bbb". The input characters are given as string at the first line of the input. Input characters are unique (there are
// no repeating characters). Examples:
//        Input	Output
//        x	xxx
//        ab	aaa aab aba abb baa bab bba bbb
//        abx	aaa aab aax aba abb abx axa axb axx baa bab bax bba bbb bbx bxa bxb bxx xaa xab xax xba xbb xbx xxa xxb xxx

import java.util.Scanner;

public class P02GenerateThirthLetterWords {
    public static void main(String[] args) {
        Scanner inputScn = new Scanner(System.in);
        String charArr = inputScn.nextLine();
        char[] arr = new char[3];
        arr[0] = charArr.charAt(0);
        arr[1] = charArr.charAt(1);
        arr[2] = charArr.charAt(2);

//        for (char first = charArr.charAt(0); first <= (int) charArr.charAt(charArr.length()-1); first++) {
//            for (char second = charArr.charAt(0); second <= (int) charArr.charAt(charArr.length()-1); second++) {
//                for (char third = charArr.charAt(0); third <= (int) charArr.charAt(charArr.length()-1); third++) {
//                    System.out.println(first + " " + second + " " + third);
//                }
//            }
//        }
        for (char i : arr ){
            for (char j : arr ){
                for (char k : arr ){
                    System.out.println(i + " " + j + " " + k);
                }
            }
        }
    }
}
