class day_4_program
{
    static void Main()
    {
        Operations o = new Operations();
        
        string card = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";

        string[] splitCard = o.StringCleaner(card);

        // string winningNums = splitCard[0];
        // string personalNums = splitCard[1];

        list<int> winningNums = o.GenerateNumberList(splitCard[0]);
        list<int> personalNums = o.GenerateNumberList(splitCard[1]);

        Console.WriteLine("winning numbers {0}, numbers I have {1}", winningNums, personalNums);

        //foreach loop of personalNums against WinningNums. Count++ each time true. Using .Contains?



    }
}
