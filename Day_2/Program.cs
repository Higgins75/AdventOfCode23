using System.ComponentModel;

class Program
{
    static void Main()
    {
        stringCleaner clean = new stringCleaner();
        const int redCubesAllowed = 12;
        const int greenCubesAllowed = 13;
        const int blueCubesAllowed = 14;

        string testString = "Game 1: 3 blue, 2 green, 6 red; 17 green, 4 red, 8 blue; 2 red, 1 green, 10 blue; 1 blue, 5 green";

        string[] cleanedString = clean.cleanString(testString);


        foreach (var substring in cleanedString)
        {
            Console.WriteLine(substring);
        }

    }
}
