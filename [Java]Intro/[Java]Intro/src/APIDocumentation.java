import com.sun.org.apache.xpath.internal.operations.Variable;
import com.sun.xml.internal.fastinfoset.util.StringArray;

import javax.sound.midi.SysexMessage;
import java.time.LocalDateTime;
import java.util.Scanner;

/**
 * Created by kasskata on 11.5.2014 г..
 */
public class APIDocumentation {
    public static void main(String[] args){
        LocalDateTime timeNow = LocalDateTime.now();
        System.out.println(timeNow);
        System.out.println(timeNow.getMonth());
        System.out.println(timeNow.minusDays(10));
        char charachter = '@';
        int numberToChar = 23;
        char chars = 23;
        System.out.println(chars);//cant convert ?!
        System.out.println(Character.toChars(81));
        for (int i = 0; i <250 ; i++) {
            System.out.println(Character.toChars(i));
        }
        Scanner number = new Scanner("number");
        Scanner numberFromString = new Scanner("1 fish 2 fish red fish blue fish");
        int first = numberFromString.nextInt();
        int second = numberFromString.nextInt();
        println(first);
        println(second);

    }
    public static void println(int number){
         System.out.println(number);
    }
}
