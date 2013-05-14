using System;

class Program
{
    static void Main(string[] args)
    {
        int endingNumber = 1001;
        double sum = 0;
        int startingNumber = 2;
        for (int i = 0; i < endingNumber; i++)
        {
            for (int j = 0; j < 8; j += 2)
            {
                sum += startingNumber * endingNumber-i;
                startingNumber += j;
            }
        }
        sum += 4 * endingNumber + 1;
        Console.WriteLine(sum);
    }
}