using System.ComponentModel;

class Day_3_Program
{
    static void Main()
    {
        fileReader f = new fileReader();
        Operations o = new Operations();

        string[] testCase = f.readFile("Day_3.txt");
        int sum = 0;



        for (int i = 0; i < testCase.Length; i++)
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

            string[] parallelstrings = [adjacentString1, adjacentString2];

            List<LocationValues> locationValues = new List<LocationValues>();

            //generates a list of number values within a string, and stores the value itself and their location
            for (int j = 0; j < stringToTest.Length; j++)
            {
                if (o.isNum(stringToTest[j]))
                {
                    locationValues.Add(new LocationValues() {location = j, value = o.getASCIIValue(stringToTest[j])});
                }
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
                    numToAdd = numToAdd * 10 + locationValues[k].value;
                    if (!firstValueSet)
                    {
                        firstValueSet = true;
                        firstValueLocation = locationValues[k].location;
                    }
                    k++;
                }
                numToAdd = numToAdd * 10 + locationValues[k].value;
                secondValueLocation = locationValues[k].location;
                
                //to account for single digit responses
                if (firstValueLocation == 0)
                {
                    firstValueLocation = secondValueLocation;
                }

                Console.WriteLine(numToAdd);

                if (o.checkEnginePart(locationValues, parallelstrings, firstValueLocation, secondValueLocation, stringToTest.Length, stringToTest))
                {
                    sum = sum + numToAdd;
                }
            }
        }

        Console.WriteLine(sum);
    }
}
