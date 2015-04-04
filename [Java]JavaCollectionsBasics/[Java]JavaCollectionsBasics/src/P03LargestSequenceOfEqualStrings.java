//Write a program to find all increasing sequences inside an
//array of integers. The integers are given in a single line
//separated by a space. Print the sequences in the order of
// their appearance in the input array, each at a single line.
// Separate the sequence elements by a space. Find also the longest
// increasing sequence and print it at the last line. If several sequences have
// the same longest length, print the leftmost of them.

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class P03LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner inputScn = new Scanner(System.in);
        String[] text = inputScn.nextLine().split(" ");
        int firstItem = 0;
        int maxLength = 1;
        int[] numbers = new int[text.length];
        List<Integer> sequence = new ArrayList<>();

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(text[i]);
        }

        for (int i = 0; i < numbers.length-1; i++)
        {
            int currentLength = 1;
            int previous = numbers[i];
            sequence.add(previous);
            int j = i + 1;
            for (; j < numbers.length; j++)
            {
                if (previous < numbers[j])
                {
                    previous = numbers[j];
                    sequence.add(previous);
                }
                else
                {
                    break;
                }
            }
            currentLength = j - i;

            if (currentLength > maxLength)
            {
                System.out.println(sequence + " ");
                sequence.clear();
                maxLength = currentLength;
                firstItem = i;
            }

        }
        System.out.print("Longest");
        for (int i = firstItem; i < firstItem + maxLength; i++)
        {
            System.out.print(" " + numbers[i]);
        }
    }
}
