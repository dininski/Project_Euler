using System;

class Program
{
    static void Main()
    {
        int currentTriangularNumberPosition = 2;
        double currentTriangularNumber = 1;
        int numberOfDivisors = 0;

        while (numberOfDivisors < 500)
        {
            numberOfDivisors = FindNumberOfDivisor(currentTriangularNumber);
            //            Console.WriteLine("{0} divisors count: {1}", currentTriangularNumber, numberOfDivisors);
            currentTriangularNumber += currentTriangularNumberPosition;
            currentTriangularNumberPosition++;
        }
        Console.WriteLine("{0} divisors count: {1}", currentTriangularNumber - currentTriangularNumberPosition + 1, numberOfDivisors);
    }

    public static int FindNumberOfDivisor(double number)
    {
        if (number == 1)
        {
            return 1;
        }

        int divisorsCount = 2;

        for (int divisor = 1; divisor < (int)Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                divisorsCount += 2;
            }
        }

        return divisorsCount;
    }
}
