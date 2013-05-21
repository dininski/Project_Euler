using System;

class Program
{
    static void Main(string[] args)
    {
        double sum = 0;

        for (int currentSide = 3; currentSide < 1003; currentSide += 2)
        {
            int currentPeaksSum = 4 * currentSide * currentSide - 6 * (currentSide - 1);
            sum += currentPeaksSum;
        }

        Console.WriteLine(sum + 1);
    }
}