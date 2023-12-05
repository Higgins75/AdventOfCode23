using System.ComponentModel;

class Day_3_Program
{
    static void Main()
    {
        //initialise functions and set up the total (sum) variable
        fileReader f = new fileReader();
        Operations o = new Operations();
        int sum = 0;

        //reads input from .txt file
        string[] testCase = f.readFile("Day_3.txt");
        



        for (int i = 0; i < testCase.Length; i++)
        {
            string stringToTest = testCase[i];

            string adjacentString1 = null;
            string adjacentString2 = null;
            string adjacentString3 = null;

            //this assigns the string above target string
            if (i > 0)
            {
                adjacentString1 = testCase[i - 1];
            }

            //this assigns the strings below target string
            if (i < testCase.Length - 1)
            {
                adjacentString2 = testCase[i + 1];
            }
            if (i < testCase.Length - 2)
            {
                adjacentString3 = testCase[i + 2];
            }

            //stores adjacent strings as an array for easier processing
            string[] parallelstrings = [adjacentString1, adjacentString2, adjacentString3];

            //generates a list of number values within a string, and stores the value itself and their location
            List<LocationValues> locationValues = new List<LocationValues>();
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

                //checks if Engine Part, if yes add to sum
                if (o.checkEnginePart(locationValues, parallelstrings, firstValueLocation, secondValueLocation, stringToTest.Length, stringToTest))
                {
                    sum = sum + numToAdd;
                }
            }
        }
        //print sum total
        Console.WriteLine(sum);
    }
}
