public class P07HowManyBitsIsOne {
    public static void main(String[] args) {
        int number = 17263;
        String numberAsStr = Integer.toBinaryString(number);
        int count = 0;
        for (int i = 0; i < numberAsStr.length(); i++) {
            if (numberAsStr.charAt(i) == '1') {
                count++;
            }
        }
        System.out.printf("how many bits is '1': %d", count);
    }
}
