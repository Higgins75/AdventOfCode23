using System.ComponentModel;

class Program
{
    static void Main()
    {
        stringCleaner clean = new stringCleaner();
        Operations o = new Operations();
        fileReader f = new fileReader();

        int GameSum = 0;

        string[] ArrayList = f.readFile("Day_2.txt");

        for (int i = 0; i < ArrayList.Length; i++)
        {
               
        int redTotal = 0;
        int greenTotal = 0;
        int blueTotal = 0;

        string[] cleanedString = clean.cleanString(ArrayList[i]);
        
        foreach (var substring in cleanedString)
        {
            if (o.redCubes(substring) > redTotal)
            {

                redTotal = o.redCubes(substring);

            }

            if (o.greenCubes(substring) > greenTotal)
            {

                greenTotal = o.greenCubes(substring);

            }

            if (o.blueCubes(substring) > blueTotal)
            {

                blueTotal = o.blueCubes(substring);
            }          
        }
        
        int sum = blueTotal * redTotal * greenTotal;
        GameSum += sum;
    }
    Console.WriteLine(GameSum);
}
}
