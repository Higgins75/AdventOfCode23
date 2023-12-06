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

    public bool isAsterisk(char test)
    {
        int value = Convert.ToInt32(test);
        if (value == 42)
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

    public int isGear(List<LocationValues> locationValues, string[] parrallelstrings, int firstValueLocation, int secondValueLocation, string testCase)
    {
        int gearValue = 0;

        //initialises strings from array
        string belowOneString = parrallelstrings[1];
        string belowTwoString = parrallelstrings[2];
        
        //sets values correctly
        if (firstValueLocation != 0)
        {
            firstValueLocation = firstValueLocation - 1;
        }        

        if (secondValueLocation != testCase.Length - 1)
        {
            secondValueLocation = secondValueLocation + 1;
        }
        
        //checks if there is an asterisk to the right, if so generates the value of the gear next to it
        if (isAsterisk(testCase[secondValueLocation]))
        {
            secondValueLocation++;
            while (isNum(testCase[secondValueLocation]))
            {
                if (gearValue != 0)
                {
                    gearValue += (gearValue * 10) + getASCIIValue(testCase[secondValueLocation]);
                    if (secondValueLocation != testCase.Length - 1)
                    {
                        secondValueLocation++;
                    }
                }
                gearValue += getASCIIValue(testCase[firstValueLocation]);
                if (secondValueLocation != testCase.Length - 1)
                {
                    secondValueLocation++;
                }
            }
        }

        for (int i = firstValueLocation; i < secondValueLocation; i++)
        {
            if (isAsterisk(belowOneString[i]))
            {
                //some code
            }
        }

        return gearValue;
    }

    public bool checkEnginePart(List<LocationValues> locationValues, string[] parallelstrings, int firstValueLocation, int secondValueLocation, string testCase)
    {
        if (firstValueLocation != 0)
        {
            firstValueLocation = firstValueLocation - 1;
        }

        if (secondValueLocation != testCase.Length - 1)
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

        if (secondValueLocation < testCase.Length)
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