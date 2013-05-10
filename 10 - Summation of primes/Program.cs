using System;
using System.Numerics;

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
        int k = 2000000;
        int nextPrime = 2;
        BigInteger result = 0;
        while (nextPrime < 2000000)
        {
            result += nextPrime;
            nextPrime = NextPrime(nextPrime);
        }
        Console.WriteLine(result);
    }
}
