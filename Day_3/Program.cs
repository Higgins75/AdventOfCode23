using System.ComponentModel;

class Day_3_Program
{
    static void Main()
    {
        fileReader f = new fileReader();
        Operations o = new Operations();

        // string[] testCase = ["467..114..", "...*......", "..35..633.", "......#...", "617*......", ".....+.58.", "..592.....", "......755.", "...$.*....", ".664.598.."];
        string[] testCase = ["467..114..", "...*......", "..35..633."];
        int sum = 0;



        for (int i = 0; i < testCase.Length;i++)
        {
            string stringToTest = testCase[i];
            
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
                // else Console.WriteLine("location {0} is not a number", j);
            }

            //trying to determine what the numbers ACTUALLY ARE
            for (int k = 0; k < locationValues.Count; k++)
            {
                int numToAdd = 0;

                while (o.hasAdjacentValue(locationValues, k))
                {
                    // Console.WriteLine("Adjacent value present");
                    numToAdd = numToAdd * 10 + locationValues[k].value;
                    // Console.WriteLine(numToAdd);
                    k++;
                }
                numToAdd = numToAdd * 10 + locationValues[k].value;
                Console.WriteLine(numToAdd);
                // sum = sum + numToAdd;
            }
        }

        // Console.WriteLine(sum);
    }
}
