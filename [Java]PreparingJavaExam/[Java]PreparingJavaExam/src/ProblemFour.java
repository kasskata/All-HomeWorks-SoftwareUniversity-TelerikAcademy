import java.util.*;

public class ProblemFour {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        String[] text = in.nextLine().split(" ");
        List<String> list = new ArrayList<>();

        for (int i = 0; i < text.length-1; i++) {
            list.add(text[i]+" "+text[i+1]);
        }

        Map<String, Integer> cards = new LinkedHashMap<String, Integer>();
        for (String card : list) {
            Integer count = cards.get(card);
            if (count == null) {
                count = 0;
            }
            cards.put(card , count + 1);
        }
        for (Map.Entry<String, Integer> entry : cards.entrySet()) {
            double precentage = (double) entry.getValue() * 100 / list.size();
            System.out.printf("%s -> %.2f%%\n", entry.getKey(), precentage);
        }
    }
}
