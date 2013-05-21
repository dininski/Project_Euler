using System;

class Program
{
    static void Main()
    {
        for (int i = 2; i < 1000; i++)
        {
            int[] numbersUsed = new int[10];
            double numberToCheck = 1.0 / i;
            bool firstDigitVisited = false;
            int currentDigit;
            do
            {
                numberToCheck *= 10;
                currentDigit = (int)numberToCheck % 10;
                if (numbersUsed[currentDigit] == 0)
                {
                    numbersUsed[currentDigit] = 1;
                }
                else
                {
                    break;
                }
            } while ((currentDigit != 0) || !firstDigitVisited);
        }
    }
}