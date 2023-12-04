using System.ComponentModel;

class Day_3_Program
{
    static void Main()
    {
        fileReader f = new fileReader();
        Operations o = new Operations();

        string[] testCase = f.readFile("Day_3.txt");
        // string[] testCase = ["467..114..", "...*......", "..35..633.", "......#...", "617*......", ".....+.58.", "..592.....", "......755.", "...$.*....", ".664.598.."];
        // string[] testCase = ["......949................-.....................351.........................557...........777..........454..538......625................120..",  ".......*......242.....201.............953........*......$..957.163...636......-...............-.............*...777..*..............&.......", "......169.....$............538...249.......840...900...256....*........*.229...........110.196..............699....*..502..........861.*...."];
        int sum = 0;



        for (int i = 0; i < testCase.Length; i++)
        {
            string stringToTest = testCase[i];
            Console.WriteLine(stringToTest);
            

            string adjacentString1 = null;
            string adjacentString2 = null;

            if (i > 0)
            {
                adjacentString1 = testCase[i - 1];
            }
            if (i < testCase.Length - 1)
            {
                adjacentString2 = testCase[i + 1];
            }
            // Console.WriteLine(adjacentString1);
            // Console.WriteLine(adjacentString2);

            string[] parallelstrings = [adjacentString1, adjacentString2];

            List<LocationValues> locationValues = new List<LocationValues>();

            //generates a list of number values within a string, and stores the value itself and their location
            for (int j = 0; j < stringToTest.Length; j++)
            {
                if (o.isNum(stringToTest[j]))
                {
                    // Console.WriteLine("location {0} is num", j);
                    locationValues.Add(new LocationValues() {location = j, value = o.getASCIIValue(stringToTest[j])});
                    // Console.WriteLine("Added {0} at {1} to List", locationValues[^1].value, locationValues[^1].location);
                }
                // else Console.WriteLine("location {0} is {1}", j, o.getASCIIValue(stringToTest[j]));
            }

            //trying to determine what the numbers ACTUALLY ARE
            for (int k = 0; k < locationValues.Count; k++)
            {
                int numToAdd = 0;
                int firstValueLocation = 0;
                int secondValueLocation = 0;
                bool firstValueSet = false;

                while (o.hasAdjacentValue(locationValues, k))
                {
                    // Console.WriteLine("Adjacent value present");
                    numToAdd = numToAdd * 10 + locationValues[k].value;
                    if (!firstValueSet)
                    {
                        firstValueSet = true;
                        firstValueLocation = locationValues[k].location;
                    }
                    // Console.WriteLine(numToAdd);
                    k++;
                }
                numToAdd = numToAdd * 10 + locationValues[k].value;
                secondValueLocation = locationValues[k].location;

                // Console.WriteLine("first location {0}, second location {1}, num to add {2}", firstValueLocation, secondValueLocation, numToAdd);
                // Console.WriteLine(numToAdd);

                if (o.checkEnginePart(locationValues, parallelstrings, firstValueLocation, secondValueLocation, stringToTest.Length, stringToTest))
                {
                    sum = sum + numToAdd;
                }
                // Console.WriteLine("First value at {0} and second value at {1}", firstValueLocation, secondValueLocation);
            }
        }

        Console.WriteLine(sum);
    }
}
