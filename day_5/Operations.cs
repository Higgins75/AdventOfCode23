using System.Text.RegularExpressions;

class Operations
{
    public List<long> GenerateNumberList(string input)
    {
        List<long> NumberList = new List<long>();
        string pattern = @"\b\d+\b";
        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            if (long.TryParse(match.Value, out long number))
            {
                NumberList.Add(number);
            }
        }
        return NumberList;
    }

    public Map GenerateMap(string input)
    {
        Map mappedPosition;

        List<long> mapNumbers = GenerateNumberList(input);

        mappedPosition.destination_range = mapNumbers[0];
        mappedPosition.source_range = mapNumbers[1];
        mappedPosition.range_length = mapNumbers[2];

        return mappedPosition;
    }

    public long LowestPosition(List<List<Map>> inputMap, long seed)
    {
        long test = seed;
        var localPositions = new List<long>();

        
        foreach (var list in inputMap)
        {
            localPositions.Clear();
            foreach (var map in list)
            {
                long Destination_range_lower = map.destination_range;
                long Destination_range_upper = Destination_range_lower + map.range_length;

                long source_range_lower = map.source_range;
                long source_range_upper = source_range_lower + map.range_length;

                Console.WriteLine(test);
                Console.WriteLine(source_range_lower + " " + source_range_upper);


                if (test >= source_range_lower && test <= source_range_upper)
                {
                    //do logic, generate positon
                    localPositions.Add(test - source_range_lower + Destination_range_lower);
                }
            }
            if (localPositions.Count !=0)
            {
                test = localPositions.AsQueryable().Min();
            }
            Console.WriteLine(test);
        }

        return test;
    }
   
}