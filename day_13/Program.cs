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
        int halfwayPoint;
        
        if (inputNorm.Length / 2 % 2 == 0)
        {
            halfwayPoint = inputNorm.Length;
        }
        else
        {
            halfwayPoint = inputNorm.Length + 1;
        }

        for(int i = halfwayPoint; i < inputNorm.Length; i++)
        {
            //generates subArrays.
            string[] newArray = GenerateSubArray(inputNorm, 1, 4);
            string[] reversedArray = GenerateSubArray(inputNorm, 4, 7);
            Array.Reverse(reversedArray);         
        }


            //this prints the subarrays for testing.
        // Console.WriteLine("New Array:");
        // foreach (string item in newArray)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine("Flipped Array:");
        // foreach (string item in reversedArray)
        // {
        //     Console.WriteLine(item);
        // }

        // //this confirms if the sub arrays are equal.
        // if (newArray.SequenceEqual(reversedArray))
        // {
        //     Console.WriteLine("mirrored");
        // }



    }

    static bool checkMirror(string[] firstHalf, string[] secondHalf)
    {
        if (firstHalf.SequenceEqual(secondHalf))
        {
            Console.WriteLine("mirrored");
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