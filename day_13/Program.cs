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

        for (int i = 0; i < inputNorm.Length; i++)
        {
            //check for vertical mirror at each position
        }

        for (int i = 0; i < inputFlip.Length; i++)
        {
            //check for horitzonal mirror at each position
        }


    }

    static bool checkMirror(string[] input, int positionToReflect)
    {
        return false;
    }

    static string[] GetStringsFromColumns(string[] baseStrings)
    {
        // Check if the array is empty or null
        if (baseStrings == null || baseStrings.Length == 0)
        {
            throw new ArgumentException("The array of strings is empty or null.");
        }

        // Get the number of columns based on the length of the first string
        int numColumns = baseStrings[0].Length;

        // Initialize a list to store the result strings
        List<string> result = new List<string>();

        // Iterate through each column
        for (int col = 0; col < numColumns; col++)
        {
            // StringBuilder to build the string for the current column
            StringBuilder columnStringBuilder = new StringBuilder();

            // Iterate through each line and append the character at the current position to the column string
            for (int row = 0; row < baseStrings.Length; row++)
            {
                // Check if the current line has enough characters
                if (col < baseStrings[row].Length)
                {
                    // Append the character at the current position to the column string
                    columnStringBuilder.Append(baseStrings[row][col]);
                }
            }

            // Add the column string to the result list
            result.Add(columnStringBuilder.ToString());
        }

        return result.ToArray();
    }
}