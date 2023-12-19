class day_10_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        string[] input = f.readFile("day_10.txt");
        Tuple<int, int> startingLocation = Tuple.Create(-1, -1);
        int count = 0;

        foreach (string line in input)
        {
            Console.WriteLine(line);
            if (line.Contains("F"))
            {
                startingLocation = Tuple.Create(count, line.IndexOf("F"));
            }
            count++;
            
        }

        Console.WriteLine(startingLocation.Item1 + " " + startingLocation.Item2);
    }
}