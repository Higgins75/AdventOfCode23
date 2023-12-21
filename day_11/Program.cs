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
        input = expandUniverseHorizontal(input);
        input = expandUniverseVertical(input);

        return input;
    }   

    static List<string> expandUniverseHorizontal (List<string> input)
    {
        for (int i = 0; i < input.Count; i++)
        {
            if (!input[i].Contains('#'))
            {
                input.Insert(i, input[i]);
                i++;
            }
        }

        return input;
    }

    static List<string> expandUniverseVertical (List<string> input)
    {
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

        foreach (int position in PositionsToEdit)
        {
            for (int i = 0; i < input.Count; i++)
        {
            if (position >= 0 && position <= input[i].Length)
            {
                input[i] = input[i].Insert(position, ".".ToString());
            }
        }
        }

        return input;
    }
}