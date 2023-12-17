class day_8_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        Operations o = new Operations();

        string[] inputFile = f.readFile("day_8.txt");

        string Instructions = inputFile[0];

        List<Map> mapList = new List<Map>();

        for (int i = 2; i < inputFile.Length; i++)
        {
            mapList.Add(o.getMap(inputFile[i]));
        } 
    }
}