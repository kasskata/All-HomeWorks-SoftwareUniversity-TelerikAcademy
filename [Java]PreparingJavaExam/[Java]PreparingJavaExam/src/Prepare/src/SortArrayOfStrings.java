import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfStrings {
    public static void main(String[] args) {

        //Scanner input = new Scanner(System.in);

        //using BufferedReader for better input
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        System.out.print("Enter number of cities = ");
        int n = 0;
        try {
            n = Integer.parseInt(in.readLine());
        } catch (IOException e) {
            e.printStackTrace();
        }

        String[] cities = new String[n];

        for (int i = 0; i < n ; i++) {
            try {
                cities[i] = in.readLine();
                //make all the cities in Upper case to compare them correctly
                cities[i] = cities[i].toUpperCase();
            } catch (IOException e) {
                e.printStackTrace();
            }

        }

       // System.out.println(cities[4]);

        Arrays.sort(cities);

        for (int i = 0; i < n ; i++) {
            System.out.println(cities[i]);
        }

    }
}
