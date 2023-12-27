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
            //check for vertical mirror at each position. Return the mirrored position.
        }

        for (int i = 0; i < inputFlip.Length; i++)
        {
            //check for horitzonal mirror at each position. Return the mirrored position.
        }


    }

    static bool checkMirror(string[] input, int positionToReflect)
    {
        return false;
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
}