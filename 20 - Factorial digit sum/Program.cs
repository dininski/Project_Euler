using System;
using System.Numerics;

namespace euler_20
{
    class Program
    {
        public static BigInteger[] factorialNumbers;

        public static BigInteger Factorial(int n)
        {
            if (factorialNumbers[n]!= 0)
            {
                return factorialNumbers[n];
            }
            factorialNumbers[n] = n * Factorial(n-1);
            return factorialNumbers[n];
        }

        static void Main(string[] args)
        {
            factorialNumbers = new BigInteger[101];
            factorialNumbers[0] = 0;
            factorialNumbers[1] = 1;
            factorialNumbers[2] = 2;
            int result = 0;
            BigInteger numberToFind = Factorial(100);
            string stringToSum = numberToFind.ToString();
            for (int i = 0; i < stringToSum.Length; i++)
            {
                result += stringToSum[i] - '0';
            }

            Console.WriteLine(result);
        }
    }
}
