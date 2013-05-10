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
        int primeAnswer = 1;
        int counter = 0;
        while (counter!=10001)
        {
            primeAnswer = NextPrime(primeAnswer);
            counter++;
        }
        Console.WriteLine(primeAnswer);
    }


}
