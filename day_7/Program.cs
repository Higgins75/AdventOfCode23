using System.Collections;
using System.Runtime.CompilerServices;

class day_7_program
{
    static void Main()
    {

        fileReader f = new fileReader();
        Operations o = new Operations();

        string[] inputFile = f.readFile("day_7.txt");
        char[] CardValueArr = ['2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A'];

        var hands = new List<(char Character, int Count)>();
        var value = new List<int>();

        foreach (string line in inputFile)
        {
            string[] sub = line.Split(' ');
            hands.Add(o.GetMostFrequentCharacters(sub[0]));
            value.Add(int.Parse(sub[1]));
        }

    }
}