using System;
using System.Collections.Generic;
using System.Text;

class day_13_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        string[] inputNorm = f.readFile("day_13.txt");
        string[] inputFlip = GetStringsFromColumns(inputNorm);
        int inputLength = inputNorm.Length;
        int halfwayPoint;
        
        if (inputNorm.Length / 2 % 2 == 0)
        {
            halfwayPoint = inputNorm.Length;
        }
        else
        {
            halfwayPoint = inputNorm.Length + 1;
        }

        for(int i = 0; i <= halfwayPoint; i++)
        {
            //generates subArrays.
            string[] newArray = GenerateSubArray(inputNorm, i, halfwayPoint - i);
            string[] reversedArray = GenerateSubArray(inputNorm, halfwayPoint - i, inputLength - i);
            Array.Reverse(reversedArray);
            checkMirror(newArray, reversedArray);         
        }
    }

    static bool checkMirror(string[] firstHalf, string[] secondHalf)
    {
        if (firstHalf.SequenceEqual(secondHalf))
        {
            // Console.WriteLine("mirrored");
            return true;
        }
        else return false;
    }

    static string[] GetStringsFromColumns(string[] baseStrings)
    {
        int numColumns = baseStrings[0].Length;

        List<string> result = new List<string>();

        for (int col = 0; col < numColumns; col++)
        {
            StringBuilder columnStringBuilder = new StringBuilder();

            for (int row = 0; row < baseStrings.Length; row++)
            {
                if (col < baseStrings[row].Length)
                {
                    columnStringBuilder.Append(baseStrings[row][col]);
                }
            }
            result.Add(columnStringBuilder.ToString());
        }

        return result.ToArray();
    }

    static T[] GenerateSubArray<T>(T[] array, int start, int end)
    {
        // Validate input indices
        if (start < 0 || end > array.Length || start > end)
        {
            throw new ArgumentOutOfRangeException("Invalid start or end position.");
        }

        // Create a new array segment based on the specified range
        ArraySegment<T> arraySegment = new ArraySegment<T>(array, start, end - start);

        // Convert the array segment to a new array
        T[] newArray = new T[arraySegment.Count];
        arraySegment.CopyTo(newArray);

        return newArray;
    }
}