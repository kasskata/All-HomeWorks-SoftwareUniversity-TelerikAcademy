import java.util.Arrays;
import java.util.Scanner;

//Write a program to enter a number n and n integer numbers and sort and print them.
// Keep the numbers in array of integers: int[].

public class P01SortArrayOfNumbers {
    public static void main(String[] args) {
        System.out.print("How many numbers u want :");
        Scanner inputScn = new Scanner (System.in);
        int n = Integer.parseInt(inputScn.next());
        int[] arrNumbers = new int[n];

        for (int i = 0; i < arrNumbers.length; i++) {
            System.out.print(i + " number: ");
            arrNumbers[i] = Integer.parseInt(inputScn.next());
        }
        Arrays.sort(arrNumbers);
        System.out.println("This is your numbers");
        for (int i = 0; i < arrNumbers.length; i++) {
            System.out.println(arrNumbers[i]);
        }
    }
}
