import java.util.List;
import java.util.Random;
import java.util.Scanner;

/**
 * Created by kasskata on 21.5.2014 г..
 */
public class P06RandomCards {
    public static void main(String[] args) {
        List<String> deck =  P03FullHouse.getDeck();
        Random handGenerator = new Random();
        Scanner inputScn = new Scanner(System.in);
        int n = Integer.parseInt(inputScn.next());
        String[]hand = new String[5];
        for (int j = 0; j < n; j++) {
            for (int i = 0; i < 5; i++) {
                hand[i] = deck.get(handGenerator.nextInt(deck.size()));
            }
            System.out.println(j+1+" "+hand[0]+" "+hand[1]+" "+hand[2]+" "+hand[3]+" "+hand[4]);
        }
    }
}
