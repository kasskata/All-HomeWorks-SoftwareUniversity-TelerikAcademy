using System;

class ComparesFloatingPointNumbers
{
    internal const float eps = 0.000001f;

    static void Main()
    {
        float a = 5.00000003f;
        float b = 5.00000001f;
        float sum = a - b;

        float aEps = a - eps;
        float bEps = b - eps;
        float sumEps = a - b;
        Console.WriteLine(sum == sumEps);
    }
}