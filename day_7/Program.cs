using System.Collections;
using System.Runtime.CompilerServices;

class day_7_program
{
    static void Main()
    {

        fileReader f = new fileReader();
        Operations o = new Operations();

        string[] inputFile = f.readFile("day_7.txt");
        long totalBetValue = 0;

        List<Hand> handsList = new List<Hand>();

        foreach (string line in inputFile)
        {
            string[] sub = line.Split(' ');

            Hand newHand = new Hand();

            newHand.handString = (sub[0]);
            newHand.betValue = int.Parse(sub[1]);
            newHand.handStrength = o.getBaseHandValue(sub[0]);           
            
            handsList.Add(newHand);
        }
        
        handsList = handsList.OrderBy(item => item.handStrength)
                                                                .ThenBy(item => o.getHighestCard(item.handString, 0))
                                                                .ThenBy(item => o.getHighestCard(item.handString, 1))
                                                                .ThenBy(item => o.getHighestCard(item.handString, 2))
                                                                .ThenBy(item => o.getHighestCard(item.handString, 3))  
                                                                .ThenBy(item => o.getHighestCard(item.handString, 4))                                                                                                                                
                                                                .ToList();
                

        foreach (var value in handsList)
        {
            Console.WriteLine(value.handString + " " + value.betValue + " " + value.handStrength);
        }

        for (int i = 0; i < handsList.Count; i++)
        {
            totalBetValue += handsList[i].betValue * (i + 1);
        }

        Console.WriteLine(totalBetValue);
    }
}