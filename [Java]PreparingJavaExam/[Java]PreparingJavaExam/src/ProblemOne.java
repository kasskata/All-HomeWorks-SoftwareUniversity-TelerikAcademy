import java.util.Scanner;

public class ProblemOne {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        int[] sum = {00,00};
        String end = new String("end");

        while(true){
            try{
               String[] time = in.next().toLowerCase().split(":");
               if (time[0].equals("end"))
               {
                   break;
               }
               int hours = Integer.parseInt(time[0]);
               int minutes = Integer.parseInt(time[1]);
               sum[0] += hours;
               sum[1] += minutes;
            }
            catch (Exception e){
            }
        }
        int temp = sum[1] / 60;
        int temp1 = sum[1]%60;
        sum[0]+=temp;
        sum[1]=temp1;
        System.out.printf("%d:%02d",sum[0],sum[1]);

    }
}
