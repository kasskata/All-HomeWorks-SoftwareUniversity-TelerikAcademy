//Write a program to count the number of words in given
// sentence. Use any non-letter character as word separator.
public class CountAllWords {
    public static void main(String[] args) {
        String text = "Java is a set of several computer " +
                "software products and specifications from" +
                " Oracle Corporation that provides a system " +
                "for developing application software and " +
                "deploying it in a cross-platform,,13" +
                "321312 computing" +
                " envir3213onment. Java 321  @#is used @# in a wide !@# variety" +
                " of computing platforms from embedded devices " +
                "and mobile phones on  the 213 low (67) end, to enterprise" +
                " servers and supercomputers on the high end.";
        String[] splicedText = text.split("[\\W]+"); //very COOL!
        System.out.println(splicedText.length);
    }
}
