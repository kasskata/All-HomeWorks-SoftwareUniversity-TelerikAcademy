package Prepare;

import java.util.Scanner;

public class tqw {
    public static void main(String[] args) {
        Scanner test = new Scanner(System.in);
        double x = test.nextDouble();
        double y = test.nextDouble();
        int result = 0;
        if(x > 0 ){
            if (y>0){
            result = 1;
            }
            else if(y<0){
                result = 4;
            }
        }
        else{
            if(y>0){
                result = 2;
            }
            else if (y<0){
                result = 3;
            }
        }
        if (x==0 && y!=0){
            result=5;
        }
        else if(y==0 && x!=0){
            result=6;
        }
        System.out.println(result);
    }
}
