using System;
using System.Numerics;
using System.Collections.Generic;

class Program
{

    private static int NextPrime(int currentPrime)
    {
        currentPrime++;
        while (!IsPrime(currentPrime))
        {
            currentPrime++;
        }
        return currentPrime;
    }

    public static bool IsPrime(int number)
    {
        int counter = 2;
        double limit = Math.Sqrt(number);
        while (counter <= limit)
        {
            if (number % counter == 0)
            {
                return false;
            }
            counter++;
        }
        return true;
    }

    static void Main(string[] args)
    {
        int primeNumber = 2;
        int primeAnswer = 0;
        long numberToTest = 600851475143;
        while (primeNumber <= Math.Sqrt(numberToTest))
        {
            if (numberToTest % primeNumber == 0)
            {
                primeAnswer = primeNumber;
                numberToTest = numberToTest / primeNumber;
            }
            primeNumber = (NextPrime(primeNumber));
        }

        Console.WriteLine(numberToTest);
    }


}
