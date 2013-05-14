using System;
using System.Numerics;

class Program
{
    static BigInteger[] fibNumbers = new BigInteger[100000];

    public static BigInteger Fib(int index)
    {
        if (index == 0)
        {
            return fibNumbers[0];
        }

        if (fibNumbers[index] == 0)
        {
            fibNumbers[index] = Fib(index - 1) + Fib(index - 2);
        }

        return fibNumbers[index];
    }

    static void Main(string[] args)
    {
        fibNumbers[0] = 1;
        fibNumbers[1] = 1;
        int currentNumber = 0;
        int digitsCount = 1;
        while (digitsCount != 1000)
        {
            Fib(currentNumber);
            digitsCount = fibNumbers[currentNumber].ToString().Length;
            currentNumber++;
        }

        Console.WriteLine(currentNumber);
    }
}