import java.util.*;

public class P03FullHouse {
    public static void main(String[] args) {
        List<String> deck = getDeck(); // our deck - 52 cards
//        deck.add("*");
//        deck.add("*");
//        deck.add("*");
//        deck.add("*");
//        deck.add("*");
        String[] hand = new String[5];
        List<String> posibleFullHouse = new ArrayList<>();
        Set<String> realCombinations = new TreeSet<>();
        System.out.println("WORKING! \n pleese W8" );

        long count=0;
        for (int i = 0; i < 52; i+=1)
        {
            hand[0] = deck.get(i);
            for (int j = 0; j < 52; j+=1)
            {
                hand[1] = deck.get(j);
                for (int k = 0; k < 52; k+=1)
                {
                    hand[2] = deck.get(k);
                    for (int l = 0; l < 52; l+=1)
                    {
                        hand[3] = deck.get(l);
                        for (int m = 0; m < 52; m+=1)
                        {
                            hand[4] = deck.get(m);
                            if(isRealHand(hand) == true) //Check if the hand is Real(e.g. 2p 2p 3p 3p 3p etc.)(method)
                            {
                                if(isFullHouse(hand) == true) { //Check if the hand is FullHouse(method)
                                    posibleFullHouse.add(hand[0]+" "+hand[1]+" "+hand[2]+" "+hand[3]+" "+hand[4]);

                                }
                            }
                        }
                    }
                }
            }
        }
        for (int i = 0; i < posibleFullHouse.size(); i++) { //sorting all String and adding in one
            String[] batman = (posibleFullHouse.get(i).split(" ")); //Batman - action hero - good name to remember vars :)
            Arrays.sort(batman);
            realCombinations.add(batman[0]+batman[1]+batman[2]+batman[3]+batman[4]);
        }
        realCombinations.forEach(x-> System.out.println(x));
        System.out.println(realCombinations.size());
    }

    private static boolean isFullHouse(String[] hand) {
        boolean isFullHouse = false;
        if (
                ((hand[0].charAt(0)==hand[1].charAt(0)) &&
                (hand[1].charAt(0)==hand[2].charAt(0))&&
                (hand[3].charAt(0)==hand[4].charAt(0)))) {
            isFullHouse = true;
        }

        return isFullHouse;
    }

    private static boolean isRealHand(String[] hand) {
        boolean realHand = true;
        for (int i = 0; i < hand.length; i++) {
            for (int j = i + 1; j < hand.length; j++) {
                if (hand[i].equals(hand[j])&& hand[i]!= "*") {
                    realHand = false;
                    break;
                }
                if (j == hand.length-1){
                    continue;
                }
            }
        }
        return realHand;
    }


    static List<String> getDeck() {
        char[] numbers = {'2','3','4','5','6','7','8','9','T','J','Q','K','A'};
        String[] color = {"\u2663", "\u2666", "\u2665", "\u2660"};
        List<String> thisDeck = new ArrayList<>();

        for (int i = 0; i < numbers.length; i++) {
            for (int j = 0; j < color.length; j++) {
                thisDeck.add(numbers[i] + "" + color[j]);
            }
        }

        return thisDeck;
    }
}