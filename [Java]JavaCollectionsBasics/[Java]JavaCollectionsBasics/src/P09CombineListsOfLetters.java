import java.util.ArrayList;
import java.util.List;

//Write a program that reads two lists of letters l1 and l2 and combines them:
// appends all letters c from l2 to the end of l1, but only when c does not appear in l1.
//Print the obtained combined list. All lists are given as sequence of letters separated by a
// single space, each at a separate line. Use ArrayList<Character> of chars
// to keep the input and output lists.
public class P09CombineListsOfLetters {
    public static void main(String[] args) {
        char[] l1 = "w e l c o m e t o s o f t u n i".toCharArray();
        char[] l2 = "j a v a p r o g r a m m i n g".toCharArray();
        boolean isNotRepeatable = true;
        List<Character> result = new ArrayList<>();
        for (int i = 0; i < l1.length; i++) {
            result.add(l1[i]);
        }

        for (int i = 0; i < l2.length; i++) {
            for (int j = 0; j < l1.length; j++) {
                if (l2[i] == l1[j]) {
                    isNotRepeatable=false;
                    break;
                }
                else{
                    isNotRepeatable = true;
                }
            }
            if (isNotRepeatable==true){
                result.add(l2[i]);
            }
        }
        System.out.println(result+" ");
    }
}
