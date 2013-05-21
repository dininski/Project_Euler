using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger result = 0;
        for (int i = 0; i < 1001; i++)
        {
            BigInteger numberRaised = i;
            for (int j = 0; j < i - 1; j++)
            {
                numberRaised *= i;
            }

            //Console.WriteLine(numberRaised);
            BigInteger lastTenDigits = numberRaised % 10000000000;
            //Console.WriteLine(lastTenDigits);
            result += lastTenDigits;
        }

        Console.WriteLine(result % 10000000000);
    }
}
