using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class day_4_program
{
    static void Main()
    {
        Operations o = new Operations();
        fileReader f = new fileReader();

        // string[] cardsCollection = ["Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53", "Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19", "Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1", "Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83", "Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36", "Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11"];
        string[] cardsCollection = f.readFile("day_4.txt");
        int totalPoints = 0;

        foreach (string card in cardsCollection)
        {

        string[] splitCard = o.StringCleaner(card); 

        var winningNums = new List<int>();
        winningNums.AddRange(o.GenerateNumberList(splitCard[0]));
        

        var personalNums = new List<int>();
        personalNums.AddRange(o.GenerateNumberList(splitCard[1]));


        
        int pointsWorth = 0;

        foreach (var number in winningNums)
        {
            if (personalNums.Contains(number))
            {
                if (pointsWorth != 0)
                {
                    pointsWorth = pointsWorth * 2;
                }
                else pointsWorth += 1;
            }
        }

        // Console.WriteLine(pointsWorth);
        totalPoints = totalPoints + pointsWorth;
        }
        Console.WriteLine(totalPoints);

    }
}
