using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        long squareOfSum=0;
        BigInteger sumOfSquares = 0;
        for (int i = 0; i <= 100; i++)
        {
            sumOfSquares += i * i;
            squareOfSum += i;
        }
        Console.WriteLine(squareOfSum);
        squareOfSum *= squareOfSum;
        Console.WriteLine(sumOfSquares-squareOfSum);
    }
}
