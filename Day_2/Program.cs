using System.ComponentModel;

class Program
{
    static void Main()
    {
        stringCleaner clean = new stringCleaner();
        Operations o = new Operations();
        fileReader f = new fileReader();
        
        const int redCubesAllowed = 12;
        const int greenCubesAllowed = 13;
        const int blueCubesAllowed = 14;

        int GameSum = 0;


        string [] ArrayList = new string[5];
        ArrayList[0] = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";
        ArrayList[1] = "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue";
        ArrayList[2] = "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red";
        ArrayList[3] = "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red";
        ArrayList[4] = "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";
        // string[] ArrayList = f.readFile("Day_2.txt");

        for (int i = 0; i < ArrayList.Length; i++)
        {
               
        int redTotal = 0;
        int greenTotal = 0;
        int blueTotal = 0;

        string[] cleanedString = clean.cleanString(ArrayList[i]);
        
        foreach (var substring in cleanedString)
        {
            // Console.WriteLine(substring);
            
            redTotal += o.redCubes(substring);
            // Console.WriteLine(redTotal);

            greenTotal += o.greenCubes(substring);
            // Console.WriteLine(greenTotal);

            blueTotal += o.blueCubes(substring);
            // Console.WriteLine(blueTotal);            
        }

        // Console.WriteLine(redTotal);
        // Console.WriteLine(greenTotal);
        // Console.WriteLine(blueTotal);

        if ((redTotal <= redCubesAllowed) && (greenTotal <= greenCubesAllowed) && (blueTotal <= blueCubesAllowed))
        {
            Console.WriteLine("Game ID {0} is valid", i + 1);
            GameSum += i + 1;
            Console.WriteLine("GameSum is {0}", GameSum);
        }
        else Console.WriteLine("Game ID {0} is not valid", i);
        }

        Console.WriteLine(GameSum);
    }
}
