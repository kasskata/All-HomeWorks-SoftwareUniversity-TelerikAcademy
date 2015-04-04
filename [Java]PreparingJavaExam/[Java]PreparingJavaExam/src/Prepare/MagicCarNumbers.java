package Prepare;

import java.util.Scanner;

public class MagicCarNumbers {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int weight = Integer.parseInt(in.next());
        int count = 0;
        int[] numbers = {10, 20, 30, 50, 80, 110, 130, 160, 200, 240};

            for (int k = 0; k <= 9999; k++) {
                int first = k / 1000 % 10;
                int second = k / 100 % 10;
                int third = k / 10 % 10;
                int forth = k % 10;
                for (int i = 0; i < numbers.length; i++) {
                    for (int j = 0; j < numbers.length; j++) {
                        int sum = 40 + numbers[i] + numbers[j] + first + second + third + forth;
                        if (weight == sum) {
                            //CAaaaaXY
                            if (first == second && second == third && third == forth) {
                                count++;
                                continue;
                            }
                            //CAabbbXY
                            else if (second == third && third == forth) {
                                count++;
                                continue;
                            }
                            //CAaaabXY
                            else if (first == second && second == third) {
                                count++;
                                continue;

                            }
                            //CAaabbXY
                            else if (first == second && third == forth) {
                                count++;
                                continue;

                            }
                            //CAababXY
                            else if (first == third && second == forth) {
                                count++;
                                continue;

                            }
                            //CAabbaXY
                            else if (first == forth && second == third) {
                                count++;
                                continue;

                            }
                        }
                    }
                }
            }
        System.out.println(count);
        //System.out.println(first + " " + second + " " + third + " " + forth + " " + numbers[i] + " " + numbers[j]);
    }
}
