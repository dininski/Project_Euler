using System;
using System.IO;
using System.Numerics;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        string path = "../../names.txt";
        StreamReader reader = new StreamReader(path);
        string[] names;
        BigInteger totalNamesScore = 0;
        using (reader)
        {
            while (!reader.EndOfStream)
            {
                names = reader.ReadLine().Split(new char[]{'"', ','}, StringSplitOptions.RemoveEmptyEntries);
                Array.Sort(names);
                for (int i = 0; i < names.Length; i++)
                {
                    BigInteger singleNameScore = 0;
                    for (int j = 0; j < names[i].Length; j++)
                    {
                        singleNameScore += (names[i][j] - 'A' + 1);
                    }
                    totalNamesScore += singleNameScore * (i + 1);
                }

            }
        }
        Console.WriteLine(totalNamesScore);
    }
}
