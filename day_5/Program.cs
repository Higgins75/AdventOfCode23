using System.Runtime.CompilerServices;
using System;
using System.Runtime;

class day_5_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        Operations o = new Operations();

        string[] testString = f.readFile("day_5_test.txt");

        // string seeds = "seeds:";
        var seeds = new List<int>();
        var soilMap = new List<Map>();
        var fertMap = new List<Map>();
        var waterMap = new List<Map>();
        var lightMap = new List<Map>();

        for (int i = 0; i < testString.Length; i++)
        {
            if (testString[i].Contains("seeds:"))
            {
                seeds.AddRange(o.GenerateNumberList(testString[i]));
            }
            if (testString[i].Contains("seed-to-soil map"))
            {
                i++;
                while (testString[i] != string.Empty)
                {
                    soilMap.Add(o.GenerateMap(testString[i]));
                    i++;
                }
            }
            if (testString[i].Contains("soil-to-fertilizer map"))
            {
                i++;
                while (testString[i] != string.Empty)
                {
                    fertMap.Add(o.GenerateMap(testString[i]));
                    i++;
                }
            }
            if (testString[i].Contains("fertilizer-to-water map"))
            {
                i++;
                while (testString[i] != string.Empty)
                {
                    waterMap.Add(o.GenerateMap(testString[i]));
                    i++;
                }
            }
            if (testString[i].Contains("water-to-light map"))
            {
                i++;
                while (testString[i] != string.Empty)
                {
                    lightMap.Add(o.GenerateMap(testString[i]));
                    i++;
                }
            }
        }

        foreach (var soil in fertMap)
        {
            Console.WriteLine(soil.destination_range + " " + soil.source_range + " " + soil.range_length);
        }

    }
}