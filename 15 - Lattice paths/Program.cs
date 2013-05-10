using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int size = 20;
        BigInteger result = 1;

        for (int i = 0; i < size; i++)
        {
            result *= (2 * size) - i;
            result /= i + 1;
        }

        Console.WriteLine(result);
    }
}
