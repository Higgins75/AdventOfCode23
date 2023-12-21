using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

class day_11_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        List<string> input = f.readFile("day_11.txt");

        input = expandUniverse(input);
        
        foreach (string line in input)
        {
            Console.WriteLine(line);
        }

    }

    static List<string> expandUniverse (List<string> input)
    {
        for (int i = 0; i < input.Count; i++)
        {
            if (!input[i].Contains('#'))
            {
                input.Insert(i, input[i]);
                i++;
            }
        }

        List<int> PositionsToEdit = new List<int>();

        for (int i = 0; i < input[0].Length; i++)
        {
            if (input[0][i] == '.')
            {
                bool passesCheck = true;
                foreach (var item in input)
                {
                    if (item[i] != '.')
                    {
                        passesCheck = false;
                        break;
                    }
                }
                if (passesCheck == true)
                {
                    PositionsToEdit.Add(i);
                }
            }
        }

        return input;
    }   
}