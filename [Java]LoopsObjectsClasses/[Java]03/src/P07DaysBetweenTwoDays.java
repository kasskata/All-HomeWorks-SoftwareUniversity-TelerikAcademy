import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;

public class P07DaysBetweenTwoDays {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        Date date1 = new Date(2000,02,28);
        Date date2 = new Date(2000,03,8);
        Calendar calendar1 = Calendar.getInstance();
        Calendar calendar2 = Calendar.getInstance();
        calendar1.setTime(date1);
        calendar2.setTime(date2);
        long milliseconds1 = calendar1.getTimeInMillis();
        long milliseconds2 = calendar2.getTimeInMillis();
        long diff = milliseconds2 - milliseconds1;
        long diffSeconds = diff / 1000;
        long diffMinutes = diff / (60 * 1000);
        long diffHours = diff / (60 * 60 * 1000);
        long diffDays = diff / (24 * 60 * 60 * 1000);
        System.out.println("\nThe Date Different Example");
        System.out.println("Time in days: " + diffDays + " days.");
    }
}
