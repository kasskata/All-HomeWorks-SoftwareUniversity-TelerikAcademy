import java.util.Scanner;

//Write a program that enters an array of strings and finds in it
// all sequences of equal elements. The input strings are given as
// a single line, separated by a space
public class p02SequencesOfEqualStrings {
    public static void main(String[] args) {

        Scanner inputScn = new Scanner(System.in);
        String[] text = inputScn.nextLine().split(" ");
        System.out.print(text[0].concat(" "));
        for (int i = 1; i < text.length; i++) {
            if (text[i-1].equals(text[i])) {
                System.out.print(text[i].concat(" "));
            }
            else if (!(text[i-1].equals(text[i]))){
                System.out.print("\n"+text[i].concat(" "));
            }

        }
    }
}