using System;

/*Write a boolean expression 
   that returns if the bit at position p 
   (counting from 0) in a given integer 
   number v has value of 1. Example: v=5; p=1  false.*/

class BitTransform
   

{
    static void Main()
    {
        int v = 35;
        int p = 7;

        
        int trueMask = 1 << p;                 //True Bit
        int trueMaskOrV = trueMask & p;            //True Bit
        int trueBit = trueMaskOrV >> p;            //True Bit
        string BitCode = Convert.ToString(v, 2).PadLeft(32, '0');

        int Mask = 1 << p;                    //false bit
        int MaskOrV = Mask | p;               //false Bit
        int falseBit = MaskOrV >> p;          //falseBit
        string BitCodefalse = Convert.ToString(v, 2).PadLeft(32, '0');


        bool isFalse = (MaskOrV == trueMaskOrV);
        Console.WriteLine(@"
v - {0}
P = {1}
V TrueBitValue-{2}
V FalseBitValue-{3}
Wrong?-{4}", v, p, trueBit, falseBit, isFalse);
        

    }
}
