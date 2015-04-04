import java.util.Scanner;

public class P07CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner inputScn = new Scanner(System.in);
        String[] text = inputScn.nextLine().split("[\\W]+");
        String searchingWord = inputScn.nextLine().toLowerCase();
        int counter = 0;
        int i = 0;
        for (int j = 0; j < text.length; j++) {
            if (text[j].toLowerCase().indexOf(searchingWord) != -1) {
                i=text[j].toLowerCase().indexOf(searchingWord);
                while (true) {
                    if (text[j].toLowerCase().indexOf(searchingWord, i) != -1) {
                        counter++;
                        i = (text[j].toLowerCase().indexOf(searchingWord, i) + searchingWord.length()) - 1;
                    }
                    if(i>=text[j].length()-1){
                        break;
                    }
                }
            }
        }
        System.out.println(counter);
    }
}
