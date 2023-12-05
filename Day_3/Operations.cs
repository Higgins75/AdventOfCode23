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
        if (value > 47 && value < 58)
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
        }

        if (secondValueLocation != stringLength - 1)
        {
            secondValueLocation = secondValueLocation + 1;
        }

        if (firstValueLocation == 0 | firstValueLocation > 0)
        {
            if (!isNum(testCase[firstValueLocation]) && !isFullStop(testCase[firstValueLocation]))
            {
                return true;
            } 
        }

        if (secondValueLocation < stringLength)
        {
            if (!isNum(testCase[secondValueLocation]) && !isFullStop(testCase[secondValueLocation]))
            {
                return true;
            } 
        }

        for (int i = firstValueLocation; i <= secondValueLocation; i++)
        {
            if (parallelstrings[0] != null)
            {
                string adjacentString1 = parallelstrings[0];
                if (!isNum(adjacentString1[i]) && !isFullStop(adjacentString1[i]))
                {
                    return true;
                }
            }
            if (parallelstrings[1] != null)
            {
                string adjacentString2 = parallelstrings[1];
                if (!isNum(adjacentString2[i]) && !isFullStop(adjacentString2[i]))
                {
                    return true;
                }
            }
        }
        return false;
    }
}