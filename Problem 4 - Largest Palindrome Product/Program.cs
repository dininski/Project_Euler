using System;
using System.Diagnostics;

class Program
{
    public static bool IsPalindrome(int number)
    {
        string numberStr = number.ToString();
        for (int i = 0; i < numberStr.Length / 2; i++)
        {
            if (numberStr[i] != numberStr[numberStr.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 1000000; i > 10000; i--)
        {
            if (IsPalindrome(i))
            {
                for (int j = 999; j > 100; j--)
                {
                    if (i % j == 0 && i/j > 100 && i/j < 999)
                    {

                        Console.WriteLine(i);
                        sw.Stop();
                        Console.WriteLine(sw.Elapsed);
                        return;
                    }
                }
            }
        }
        
    }
}