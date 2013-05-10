using System;

class Program
{
    public static void StartWalk(int[] firstRow, int[] secondRow)
    {
        for (int i = 0; i < secondRow.Length; i++)
        {
            //if it is the last element
            if (i == secondRow.Length - 1)
            {
                secondRow[i] += firstRow[i-1];
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
        string[] pyramid = new string[15];
        pyramid[0] = "75";
        pyramid[1] = "95 64";
        pyramid[2] = "17 47 82";
        pyramid[3] = "18 35 87 10";
        pyramid[4] = "20 04 82 47 65";
        pyramid[5] = "19 01 23 75 03 34";
        pyramid[6] = "88 02 77 73 07 63 67";
        pyramid[7] = "99 65 04 28 06 16 70 92";
        pyramid[8] = "41 41 26 56 83 40 80 70 33";
        pyramid[9] = "41 48 72 33 47 32 37 16 94 29";
        pyramid[10] = "53 71 44 65 25 43 91 52 97 51 14";
        pyramid[11] = "70 11 33 28 77 73 17 78 39 68 17 57";
        pyramid[12] = "91 71 52 38 17 14 91 43 58 50 27 29 48";
        pyramid[13] = "63 66 04 68 89 53 67 30 73 16 69 87 40 31";
        pyramid[14] = "04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
        int[] tempNumbers = new int[15];
        int[] firstRow = new int[1];
        int[] secondRow = new int[1];
        for (int i = 0; i < pyramid.Length - 1; i++)
        {
            if (i == 0)
            {
                string[] firstRowStr = pyramid[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string[] secondRowStr = pyramid[i + 1].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

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
            }
            else
            {
                firstRow = secondRow;
                string[] secondRowStr = pyramid[i + 1].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                secondRow = new int[secondRowStr.Length];
                for (int k = 0; k < secondRowStr.Length; k++)
                {
                    secondRow[k] = int.Parse(secondRowStr[k]);
                }
            }
            StartWalk(firstRow, secondRow);

        }

        int max = int.MinValue;
        for (int i = 0; i < secondRow.Length; i++)
        {
            if (secondRow[i] > max)
            {
                max = secondRow[i];
            }
        }

        Console.WriteLine(max);
    }
}
