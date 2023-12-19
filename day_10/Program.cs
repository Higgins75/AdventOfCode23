using System.Collections;
using System.Globalization;

class day_10_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        string[] input = f.readFile("day_10.txt");
        Tuple<int, int> startingLocation = Tuple.Create(-1, -1);
        int stepsTaken = 0;

        char[] East = {'-', 'J', '7'};
        char[] South = {'|', 'J', 'L'};
        char[] West = {'-', 'F', 'L'};
        char[] North = {'|', 'F', '7'};

        int Startcount = 0;
        foreach (string line in input)
        {
            if (line.Contains("F"))
            {
                startingLocation = Tuple.Create(Startcount, line.IndexOf("S"));
                break;
            }
            Startcount++;    
        }

        



        Console.WriteLine(input[1][1]);
    }

    public bool isComplete(Tuple<int, int> location, string[] input)
    {
        if (input[location.Item1][location.Item2] == 'S')
        {
            return true;
        }
        else return false;
    }
}