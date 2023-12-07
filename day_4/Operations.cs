class Operations
{
    public string[] StringCleaner(string toClean)
    {
        string[] cleanedString = toClean.Split(':');
        string[] stringArray = cleanedString[1].Split('|');
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = stringArray[i].Trim();
        }
        return stringArray;
    }

    public List<int> GenerateNumberList(string card)
    {
        List<int> NumberList = new List<int>();
        for (int i = 0; i < card.Length; i++)
        {
            if (isNum(card[i]))
            {
                //locationValues.Add(new LocationValues() {location = j, value = o.getASCIIValue(stringToTest[j])});
                NumberList.Add(getASCIIValue(card[i]) * 10 + getASCIIValue[card[i + 1]]);
                i++;
            }
        }
        return NumberList;
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
    public int getASCIIValue(char test)
    {
        return Convert.ToInt32(test - 48);
    }
    
}