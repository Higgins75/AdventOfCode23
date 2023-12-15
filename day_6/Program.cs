class day_6_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        Operations o = new Operations();

        string[] file = f.readFile("day_6_test.txt");
        int totalWins = 0;
        
        var time = new List<int>();
        var distance = new List<int>();

        time.AddRange(o.GenerateNumberList(file[0]));
        distance.AddRange(o.GenerateNumberList(file[1]));

        int numOfRaces = time.Count;


        for (int i = 0; i < numOfRaces; i++)
        {
            if (totalWins == 0)
            {
                totalWins += o.getWins(time[i], distance[i]);
            }
            else 
            {
                totalWins = totalWins * o.getWins(time[i], distance[i]);
            }
        }

        Console.WriteLine(totalWins);

    }
}