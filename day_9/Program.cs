class day_9_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        Operations o = new Operations();

        string[] inputText = f.readFile("day_9.txt");

        foreach (string history in inputText)
        {
            List<int> numbers = o.GenerateNumberList(history);

            
        }
    }
}