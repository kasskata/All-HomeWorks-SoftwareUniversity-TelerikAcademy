using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Напишете програма, която кодира текст по даден шифър като прилага шифъра побуквено с операция XOR
//(изключващо или) върху текста. Кодирането трябва да се извършва като се прилага XOR между пър- вата 
//буква от текста и първата буква на шифъра, втората буква от текста и втората буква от шифъра и т.н. до
//последната буква от шифъра, след което се продължава отново с първата буква от шифъра и поредната буква 
//от текста. Отпечатайте резултата като поредица от Unicode кодирани екраниращи символи.
//Примерен текст: "Nakov".Примерен шифър: "ab". Примерен резултат: "\u002f\u0003\u000a\u000d\u0017". 
class Cipher
{
    static void Main()
    {
        string text = "Nakov";
        List <ushort> update = new List<ushort>();
        string cipher = "ab";

        for (int i = 0,j=0; i < text.Length; i++,j++)
        {
            if (j == cipher.Length)
            {
                j = 0;
            }
            update.Add((char)(text[i] ^ cipher[j]));
            Console.WriteLine("Encode {1} ==> \\u{0:x4}",(update[i]),text[i]);
        }
        for (int i = 0; i < update.Count; i++)
        {
            
        }
    }
}
