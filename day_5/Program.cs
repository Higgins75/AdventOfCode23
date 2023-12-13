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
        var seeds = new List<long>();
        var soilMap = new List<Map>();
        var fertMap = new List<Map>();
        var waterMap = new List<Map>();
        var lightMap = new List<Map>();
        var tempMap = new List<Map>();
        var humidMap = new List<Map>();
        var locMap = new List<Map>();

        long lowestPosition = 99999;
        bool lowestPositionSet = false;


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
            if (testString[i].Contains("light-to-temperature map"))
            {
                i++;
                while (testString[i] != string.Empty)
                {
                    tempMap.Add(o.GenerateMap(testString[i]));
                    i++;
                }
            }
            if (testString[i].Contains("temperature-to-humidity"))
            {
                i++;
                while (testString[i] != string.Empty)
                {
                    humidMap.Add(o.GenerateMap(testString[i]));
                    i++;
                }
            }
            if (testString[i].Contains("humidity-to-location map"))
            {
                while (testString[i] != string.Empty && i < testString.Length - 1)
                {
                    i++;
                    locMap.Add(o.GenerateMap(testString[i]));
                }
            }
            
        }

        foreach (var seed in seeds)
        {
            long tempPosition = o.LowestPosition(soilMap, seed);
            if (lowestPositionSet == false && tempPosition > 0)
            {
                lowestPosition = tempPosition;
                lowestPositionSet = true;
            }
            else if (tempPosition < lowestPosition && lowestPositionSet == true && tempPosition < 0)
            {
                lowestPosition = tempPosition;
            }
        }

        Console.WriteLine(lowestPosition);

    }
}