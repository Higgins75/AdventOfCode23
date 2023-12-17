class day_8_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        Operations o = new Operations();

        string[] inputFile = f.readFile("day_8.txt");

        string instructions = inputFile[0];
        string finalInputToLocate = "ZZZ";
        bool inputLocated = false;
        int count = 0;

        List<Map> mapList = new List<Map>();

        for (int i = 2; i < inputFile.Length; i++)
        {
            mapList.Add(o.getMap(inputFile[i]));
        } 

        Map mapToTest = mapList[0];

        while (inputLocated == false)
        {
            foreach (char c in instructions)
            {
                switch (c)
                {
                    case 'R':
                    if (mapToTest.rString == finalInputToLocate)
                    {
                        inputLocated = true;
                        Console.WriteLine($"found ZZZ on R of {mapToTest.indexOfString}");
                        count++;
                        break;
                    }
                    foreach (var map in mapList)
                    {
                        if (map.indexOfString == mapToTest.rString)
                        {
                            mapToTest = map;
                            count++;
                            break;
                        }
                    }
                    
                    break;

                    case 'L':
                    if (mapToTest.lString == finalInputToLocate)
                    {
                        inputLocated = true;
                        Console.WriteLine($"found ZZZ on L of {mapToTest.indexOfString}");
                        count++;
                        break;
                    }
                    foreach (var map in mapList)
                    {
                        if (map.indexOfString == mapToTest.lString)
                        {
                            mapToTest = map;
                            count++;
                            break;
                        }
                    }
                    break;
                }
            }
        }

        Console.WriteLine($"Found ZZZ at {mapToTest.indexOfString} in {count}");
    }
}