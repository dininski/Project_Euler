using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        BigInteger number = 1;
        int result = 0;
        for (int i = 0; i < 1000; i++)
        {
            number *= 2;
        }

        for (int i = 0; i < number.ToString().Length; i++)
        {
            result += number.ToString()[i] - '0';
        }

        Console.WriteLine(result);
    }
}