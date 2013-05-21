using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedSet<double> numbers = new SortedSet<double>();

        for (int a = 2; a <= 100; a++)
        {
            for (int b = 2; b <= 100; b++)
            {
                double result = Math.Pow(a, b);
                if (!numbers.Contains(result))
                {
                    
                }
                numbers.Add(result);
            }
        }

        Console.WriteLine(numbers.Count);
    }
}