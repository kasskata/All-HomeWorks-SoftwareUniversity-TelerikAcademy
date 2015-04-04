import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

public class P11MostFrequentWord {
    public static void main(String[] args) {
        String[] textReady = "Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.".toLowerCase().split("[\\W]+");
        Arrays.sort(textReady);
        Map<String, Integer> wordsCount = new HashMap<String, Integer>();

        for (String word : textReady) {
            Integer count = wordsCount.get(word);
            if (count == null) {
                count = 0;
            }
            wordsCount.put(word, count+1);
        }
        int max = 0;
        for (String word : textReady){
            Integer count = wordsCount.get(word);
            if (max < count){
                max = count;
            }
        }
        for (Map.Entry<String, Integer> e : wordsCount.entrySet()) {
            if (e.getValue()==max){
                System.out.println(e.getKey()+" -> "+e.getValue());
            }
        }
    }
}
