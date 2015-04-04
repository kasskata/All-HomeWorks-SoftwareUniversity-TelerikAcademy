package Prepare;

import java.util.Scanner;

import java.util.ArrayList;

/**
 * Created by kasskata on 25.5.2014 г..
 */
public class test {
    public static void main(String[] args) {
        String[] letters = { "A", "B", "C", "E", "H", "K", "M", "P", "T", "X" };
        ArrayList<String> listOfNum = new ArrayList<>();
        int numbersCounter = 0;
        Scanner sc = new Scanner(System.in);
        int inputSum = sc.nextInt();

        for (int i = 0; i <= 9999; i++) {
            String number = "";
            if (i < 1000) {
                number = "0";
            }

            if (i < 100) {
                number = "00";
            }

            if (i < 10) {
                number = "000";
            }

            number += i;
            if ((number.charAt(0) == number.charAt(1) && number.charAt(0) == number.charAt(2)) || (number.charAt(1) == number.charAt(2) && number.charAt(1) == number.charAt(3))|| (number.charAt(0) == number.charAt(1) && number.charAt(2) == number.charAt(3))
                    || (number.charAt(0) == number.charAt(2) && number
                    .charAt(1) == number.charAt(3))
                    || (number.charAt(0) == number.charAt(3) && number
                    .charAt(1) == number.charAt(2))) {
                listOfNum.add("CA" + number);
            }

        }

        for (int i = 0; i < listOfNum.size(); i++) {
            for (int j = 0; j < letters.length; j++) {
                for (int k = 0; k < letters.length; k++) {
                    String wholeNumbers = listOfNum.get(i) + letters[j]
                            + letters[k];
                    int sum = 0;
                    for (int l = 0; l < wholeNumbers.length(); l++) {
                        switch (wholeNumbers.charAt(l)) {

                            case 'A':
                                sum += 10;
                                break;
                            case 'B':
                                sum += 20;
                                break;
                            case 'C':
                                sum += 30;
                                break;
                            case 'E':
                                sum += 50;
                                break;
                            case 'H':
                                sum += 80;
                                break;
                            case 'K':
                                sum += 110;
                                break;
                            case 'M':
                                sum += 130;
                                break;
                            case 'P':
                                sum += 160;
                                break;
                            case 'T':
                                sum += 200;
                                break;
                            case 'X':
                                sum += 240;
                                break;
                            case '1':
                                sum += 1;
                                break;
                            case '2':
                                sum += 2;
                                break;
                            case '3':
                                sum += 3;
                                break;
                            case '4':
                                sum += 4;
                                break;
                            case '5':
                                sum += 5;
                                break;
                            case '6':
                                sum += 6;
                                break;
                            case '7':
                                sum += 7;
                                break;
                            case '8':
                                sum += 8;
                                break;
                            case '9':
                                sum += 9;
                                break;
                            default:
                                break;
                        }

                    }
                    if (sum == inputSum) {
                        numbersCounter++;
                    }
                }
            }
        }
        System.out.println(numbersCounter);
    }
}