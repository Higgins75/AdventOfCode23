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

    public long LowestPosition(List<Map> inputMap, long seed)
    {
        long position = 9999999;
        long tempPosition;

        

        foreach (var map in inputMap)
        {
            long Destination_range_lower = map.destination_range;
            long Destination_range_upper = Destination_range_lower + map.range_length;

            long source_range_lower = map.source_range;
            long source_range_upper = source_range_lower + map.range_length;

            Console.WriteLine(seed);
            Console.WriteLine(source_range_lower + " " + source_range_upper);


            if (seed >= source_range_lower && seed <= source_range_upper)
            {
                //do logic, generate positon
                tempPosition = seed - source_range_lower + Destination_range_lower;
                if (tempPosition < position && tempPosition > 0)
                {
                    position = tempPosition;
                }
            }
        }

        return position;
    }
   
}