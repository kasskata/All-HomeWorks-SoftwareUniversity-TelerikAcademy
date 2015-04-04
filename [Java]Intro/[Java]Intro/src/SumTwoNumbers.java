
public class SumTwoNumbers {
    public static  void main(String[] args){
       int sum = 0;
        //example with loop its for me :)
        for (int i = 0; i < 100; i+=3) {
            sum = i+i;
        }
        Clear(sum);
        sum = 5+3;
        System.out.println(sum);
        Clear(sum);
        sum = 8-1;
        System.out.println(sum);
        Clear(sum);
        sum = 10123-3213;
        System.out.println(sum);

    }
    public static int Clear(int sum){
        return sum=0;
    }
}
