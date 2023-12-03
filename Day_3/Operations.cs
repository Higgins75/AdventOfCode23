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
}