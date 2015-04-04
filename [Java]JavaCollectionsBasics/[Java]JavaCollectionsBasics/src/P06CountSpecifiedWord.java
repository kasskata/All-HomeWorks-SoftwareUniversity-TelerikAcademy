import java.util.Scanner;

//Write a program to find how many times a word appears in
// given text. The text is given at the first input line.
// The target word is given at the second input line. The
// output is an integer number. Please ignore the character
// casing. Consider that any non-letter character is a word
// separator
public class P06CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner inputScn = new Scanner(System.in);
        String[] text = inputScn.nextLine().split("[\\W]+");
        String searchingWord = inputScn.nextLine();
        int counter = 0;
        for (int i = 0; i < text.length; i++) {
            if (text[i].toLowerCase().matches(searchingWord)){
                counter++;
            }
        }
        System.out.println(counter);
    }
}
