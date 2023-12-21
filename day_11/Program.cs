using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class day_11_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        List<string> input = f.readFile("day_11.txt");

        input = expandUniverse(input);

        List<(int y, int x)> galaxyLocations = findGalaxyLocations(input);

        List<int> distances = new List<int>();

        for (int i = 0; i < galaxyLocations.Count - 1; i++)
        {
            for (int j = i + 1; j < galaxyLocations.Count; j++)
            {
                int item1y = galaxyLocations[i].y;
                int item1x = galaxyLocations[i].x;
                int item2y = galaxyLocations[j].y;
                int item2x = galaxyLocations[j].x;

                int differencey = Math.Abs(item1y - item2y);
                int differencex = Math.Abs(item1x - item2x);

                distances.Add(differencey + differencex);
            }
        }

        int sum = 0;
        foreach (var distance in distances)
        {
            sum += distance;
        }

        Console.WriteLine(sum);

    }

    static List<string> expandUniverse (List<string> input)
    {
        input = expandUniverseHorizontal(input);
        input = expandUniverseVertical(input);

        return input;
    }   

    static List<(int y, int x)> findGalaxyLocations (List<string> input)
    {
        List<(int y, int x)> galaxyLocations = new List<(int y, int x)>();
        int y = 0;
        int x = 0;

        foreach (string line in input)
        {
            x = 0;
            foreach (char character in line)
            {
                if (character == '#')
                {
                    galaxyLocations.Add((y, x));
                }
                x++;
            }
            y++;
        }


        return galaxyLocations;
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
        int count = 0;
        foreach (int position in PositionsToEdit)
        {   
            for (int i = 0; i < input.Count; i++)
            {
                if (position >= 0 && position <= input[i].Length)
                {
                    input[i] = input[i].Insert(position + count, ".".ToString());
                }
            }
            count++;
        }

        return input;
    }
}