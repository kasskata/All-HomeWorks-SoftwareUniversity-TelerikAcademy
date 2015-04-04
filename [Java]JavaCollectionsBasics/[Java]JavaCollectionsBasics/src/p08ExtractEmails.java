//Write a program to extract all email addresses from given text.
// The text comes at the first input line.
// Print the emails in the output, each at a separate line.
// Emails are considered to be in format <user>@<host>, where:
//        •	<user> is a sequence of letters and digits, where
// '.', '-' and '_' can appear between them. Examples of valid users:
// "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345".
// Examples of invalid users: ''--123", ".....", "nakov_-", "_steve", ".info".
//        •	<host> is a sequence of at least two words, separated by dots '.'.
// Each word is sequence of letters and can have hyphens '-' between the letters.
// Examples of hosts: "softuni.bg", "software-university.com", "intoprogramming.info",
// "mail.softuni.org". Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-".
//        •	Example of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk,
// no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy.

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class p08ExtractEmails {
    public static void main(String[] args) {

        String content =  "Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.  ";
        String emails = extractEmail(content);
        System.out.println(emails);
    }
    public static String extractEmail(String content) {
        String email = null;
        String regex = "(\\w+)(\\.\\w+)*@(\\w+\\.)(\\w+)(\\.\\w+)*";
        Pattern pattern = Pattern.compile(regex);
        Matcher matcher = pattern.matcher(content);
        while (matcher.find()) {
            email = matcher.group();

            if(!isValidEmailAddress(email)){
                email=null;
            }

            break;
        }
        return email;
    }

    public static boolean isValidEmailAddress(String emailAddress) {
        String expression = "^[\\w\\-]([\\.\\w])+[\\w]+@([\\w\\-]+\\.)+[A-Z]{2,4}$";
        CharSequence inputStr = emailAddress;
        Pattern pattern = Pattern.compile(expression, Pattern.CASE_INSENSITIVE);
        Matcher matcher = pattern.matcher(inputStr);
        return matcher.matches();

    }
}
