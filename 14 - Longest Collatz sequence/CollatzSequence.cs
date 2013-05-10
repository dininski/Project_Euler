using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class CollatzSequence
{
    public static Dictionary<BigInteger, int> numberAndChain;

    private static int CalculateCollatzChain(BigInteger number)
    {
        if (!numberAndChain.ContainsKey(number))
        {
            if (number % 2 == 0)
            {
                numberAndChain[number] = 1 + CalculateCollatzChain(number / 2);
            }
            else
            {
                numberAndChain[number] = 1 + CalculateCollatzChain(number * 3 + 1);
            }
        }
        return numberAndChain[number];
    }

    static void Main(string[] args)
    {
        numberAndChain = new Dictionary<BigInteger, int>();
        numberAndChain.Add(1, 1);
        numberAndChain.Add(2, 2);
        for (int number = 500000; number < 1000000; number++)
        {
            CalculateCollatzChain(number);            
        }
        List<KeyValuePair<BigInteger, int>> chainNumberPairs = numberAndChain.ToList();
        chainNumberPairs.Sort((firstPair, nextPair) =>
        {
            return nextPair.Value.CompareTo(firstPair.Value);
        });
        Console.WriteLine(chainNumberPairs[0]);
    }


}
