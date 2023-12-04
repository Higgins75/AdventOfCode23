using System.Runtime.InteropServices;

class Operations
{
    public int getASCIIValue(char test)
    {
        return Convert.ToInt32(test - 48);
    }
    
    public bool isNum(char test)
    {
        int value = Convert.ToInt32(test);
        if (value > 48 && value < 58)
        {
            return true;
        }
        return false;
    }

    //46 is the ascii 
    public bool isFullStop(char test)
    {
        int value = Convert.ToInt32(test);
        if (value == 46)
        {
            return true;
        }
        return false;
    }

    public bool hasAdjacentValue(List<LocationValues> locationValues, int listPosition)
    {

        if (listPosition + 1 >= locationValues.Count)
        {
            return false;
        }
        if (locationValues[listPosition].location + 1 == locationValues[listPosition + 1].location)
        {
            return true;
        }
        return false;
    }

    public bool checkEnginePart(List<LocationValues> locationValues, string[] parallelstrings, int firstValueLocation, int secondValueLocation, int stringLength, string testCase)
    {
        if (firstValueLocation != 0)
        {
            firstValueLocation = firstValueLocation - 1;
            // Console.WriteLine("first value is {0}", firstValueLocation);
        }
        // else Console.WriteLine("first value is {0}", firstValueLocation);

        if (secondValueLocation != stringLength)
        {
            secondValueLocation = secondValueLocation + 1;
            // Console.WriteLine("second value is {0}", secondValueLocation);
        }
        // else Console.WriteLine("second value is {0}", secondValueLocation);

        if (firstValueLocation != 0)
        {
            if (!isNum(testCase[firstValueLocation]) && !isFullStop(testCase[firstValueLocation]))
            {
                Console.WriteLine("num is valid");
                return true;
            } 
            else Console.WriteLine("location {0} contains {1}", firstValueLocation - 1, getASCIIValue(testCase[firstValueLocation - 1]));
        }

        if (secondValueLocation < stringLength - 1)
        {
            if (!isNum(testCase[secondValueLocation]) && !isFullStop(testCase[secondValueLocation]))
            {
                Console.WriteLine("num is valid");
                return true;
            } 
            else Console.WriteLine("location {0} contains {1}", secondValueLocation + 1, getASCIIValue(testCase[secondValueLocation + 1]));
        }

        for (int i = firstValueLocation; i <= secondValueLocation; i++)
        {
            if (parallelstrings[0] != null)
            {
                string adjacentString1 = parallelstrings[0];
                // Console.WriteLine("Testing string {0} for char at location {1}", adjacentString1, i);
                if (!isNum(adjacentString1[i]) && !isFullStop(adjacentString1[i]))
                {
                    Console.WriteLine("num is valid");
                    return true;
                }
                else Console.WriteLine("location {0} contains {1}", i, getASCIIValue(adjacentString1[i]));
            }
            if (parallelstrings[1] != null)
            {
                string adjacentString2 = parallelstrings[1];
                // Console.WriteLine("Testing string {0} for char at location {1}", adjacentString2, i);
                if (!isNum(adjacentString2[i]) && !isFullStop(adjacentString2[i]))
                {
                    Console.WriteLine("num is valid");
                    return true;
                }
                else Console.WriteLine("location {0} contains {1}", i, getASCIIValue(adjacentString2[i]));
            }
        }
        Console.WriteLine("num is not valid");
        return false;
    }
}