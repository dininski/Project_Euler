using System;

class Program
{
    static void Main()
    {
        int a, b, c;
        for (a = 1; a < 1000; a++)
        {
            for (b = 2; b < 1000; b++)
            {
                for (c = 1000 - b - a; c < 1000; c++)
                {
                    if (a < b && b < c && a + b + c == 1000 && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        Console.WriteLine(a * b * c);
                    }
                }
            }
        }
    }
}
