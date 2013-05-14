using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int CalculateSumOfProperDivisors(int number)
    {
        int sum = 0;
        for (int divisor = 1; divisor <= number / 2; divisor++)
        {
            if (number % divisor == 0)
            {
                sum += divisor;
            }
        }

        return sum;
    }

    static void Main(string[] args)
    {
        int sum = 0;
        for (int currentNumber = 2; currentNumber < 10000; currentNumber++)
        {
            int sumOfDivisors = CalculateSumOfProperDivisors(currentNumber);
            int amicableCalculation = CalculateSumOfProperDivisors(sumOfDivisors);
            if (currentNumber == amicableCalculation && currentNumber!=sumOfDivisors)
            {
                sum += currentNumber + sumOfDivisors;
            }
        }

        Console.WriteLine(sum / 2);
    }
}