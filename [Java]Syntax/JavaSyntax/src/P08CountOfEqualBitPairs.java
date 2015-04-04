public class P08CountOfEqualBitPairs {
    public static void main(String[] args) {
        int number = 5343;
        String numberAsStr = Integer.toBinaryString(number);
        int count = 0;
        for (int i = 0; i < numberAsStr.length()-1; i++) {
            if (numberAsStr.charAt(i) == (numberAsStr.charAt(i+1))) {
                count++;
            }
        }
        System.out.printf("how many bits is '11' or '00': %d", count);
    }
}
