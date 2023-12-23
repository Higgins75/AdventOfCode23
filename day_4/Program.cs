using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class day_4_program
{
    static void Main()
    {
        fileReader f = new fileReader();

        string[] cardsCollection = f.readFile("day_4.txt");
        int totalPoints = 0;

        foreach (string card in cardsCollection)
        {
        string[] splitCard = StringCleaner(card); 
        int cardWorth = 0;

        var winningNums = new List<int>();
        winningNums.AddRange(GenerateNumberList(splitCard[0]));
        
        var personalNums = new List<int>();
        personalNums.AddRange(GenerateNumberList(splitCard[1]));



        foreach (var number in winningNums)
        {
            if (personalNums.Contains(number))
            {
                if (cardWorth != 0)
                {
                    cardWorth = cardWorth * 2;
                }
                else cardWorth += 1;
            }
        }

        // Console.WriteLine(pointsWorth);
        totalPoints = totalPoints + cardWorth;
        }
        Console.WriteLine(totalPoints);

    }
    static string[] StringCleaner(string toClean)
    {
        string[] cleanedString = toClean.Split(':');
        string[] stringArray = cleanedString[1].Split('|');
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = stringArray[i].Trim();
        }
        return stringArray;
    }

    static List<int> GenerateNumberList(string input)
    {
        List<int> NumberList = new List<int>();
        string pattern = @"\b\d+\b";
        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            if (int.TryParse(match.Value, out int number))
            {
                NumberList.Add(number);
            }
        }
        return NumberList;
    } 
    
}
