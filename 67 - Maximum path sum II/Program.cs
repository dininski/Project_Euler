using System;
using System.IO;

class Program
{

    public static void StartWalk(int[] firstRow, int[] secondRow)
    {
        for (int i = 0; i < secondRow.Length; i++)
        {
            if (i == secondRow.Length - 1)
            {
                secondRow[i] += firstRow[i - 1];
            }
            if (i == 0)
            {
                secondRow[i] += firstRow[i];
            }
            else
            {
                if (i < secondRow.Length - 1)
                {
                    secondRow[i] += firstRow[i] < firstRow[i - 1] ? firstRow[i - 1] : firstRow[i];
                }
            }
        }
    }

    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("../../triangle.txt");
        int[] firstRow = new int[1];
        int[] secondRow = new int[1];
        int i = 0;
        using (sr)
        {
            int[] tempNumbers = new int[15];

            while (!sr.EndOfStream)
            {
                

                if (i == 0)
                {
                    string[] firstRowStr = sr.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] secondRowStr = sr.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    firstRow = new int[firstRowStr.Length];
                    for (int j = 0; j < firstRowStr.Length; j++)
                    {
                        firstRow[j] = int.Parse(firstRowStr[j]);
                    }

                    secondRow = new int[secondRowStr.Length];
                    for (int k = 0; k < secondRowStr.Length; k++)
                    {
                        secondRow[k] = int.Parse(secondRowStr[k]);
                    }
                    i++;
                }
                else
                {
                    firstRow = secondRow;
                    string[] secondRowStr = sr.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    secondRow = new int[secondRowStr.Length];
                    for (int k = 0; k < secondRowStr.Length; k++)
                    {
                        secondRow[k] = int.Parse(secondRowStr[k]);
                    }
                }
                StartWalk(firstRow, secondRow);

            }
            Array.Sort(secondRow);
            Array.Reverse(secondRow);
            Console.WriteLine(secondRow[0]);
        }


    }
}