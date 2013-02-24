using System;

class Program
{
    public static int NumberOfDivisors(int number)
    {
        int counter = 2 ;
        for (int i = 1; i < number/2; i++)
        {
            if (number % i == 0)
            {
                counter++;                       
            }
        }
        return counter;
    }

    static void Main(string[] args)
    {
        int[] numberDivisors = new int[10000];
        for (int i = 20; i < 100000; i++)
        {
        }
    }
}