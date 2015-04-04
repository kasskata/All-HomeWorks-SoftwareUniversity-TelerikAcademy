import com.sun.deploy.util.StringUtils;


import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by kasskata on 11.5.2014 г..
 */
public class SortArrayofStrings {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);
          int n = input.nextInt();
        String[] arr = new String[n];

        for (int i = 0; i < arr.length; i++) {
            arr[i] = input.nextLine();
        }
        Arrays.sort(arr);
        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }


    }
}
