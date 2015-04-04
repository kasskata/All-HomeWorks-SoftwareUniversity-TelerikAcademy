import java.util.Arrays;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

//At the first line at the console you are given a piece of
// text. Extract all words from it and print them in
// alphabetical order. Consider each non-letter character as
// word separator. Take the repeating words only once. Ignore
// the character casing. Print the result words in a single
// line, separated by spaces
public class P10ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner inputScn = new Scanner(System.in);
        String[] text = inputScn.nextLine().toLowerCase().split("[\\W]+");
        Arrays.sort(text);
        Set<String> result = new TreeSet<>();

        for (int i = 0; i < text.length; i++) {
            result.add(text[i]);
        }
        result.forEach(x-> System.out.print(x+" "));
    }
}
