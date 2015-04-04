import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

public class CurrentDateTime {
    public static void main(String[] args) {
        System.out.print("Local date and time: ");

        DateFormat dateFormat = new SimpleDateFormat("dd/MM/yy HH:mm a");

        //show date time with Date class
        Date date = new Date();
        System.out.println(dateFormat.format(date));

        //show date with Calendar class
        Calendar cal = Calendar.getInstance();
        System.out.println(dateFormat.format(cal.getTime()));
    }
}
