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
        Map mapToTest = new Map();

        List<Map> mapList = new List<Map>();

        for (int i = 2; i < inputFile.Length; i++)
        {
            mapList.Add(o.getMap(inputFile[i]));
        } 

        foreach (var map in mapList)
        {
            if (map.indexOfString == "AAA")
            {
                mapToTest = map;
            }
        }

        Console.WriteLine(mapToTest.indexOfString + " " + mapToTest.lString + " " + mapToTest.rString);

        while (!inputLocated)
        {
            foreach (char c in instructions)
            {
                switch (c)
                {
                    case 'R':
                    if (mapToTest.rString == finalInputToLocate)
                    {
                        inputLocated = true;
                        count++;
                        Console.WriteLine($"found ZZZ on R of {mapToTest.indexOfString}");
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
                        count++;
                        Console.WriteLine($"found ZZZ on L of {mapToTest.indexOfString}");
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