public class stringCleaner
{
    public string[] cleanString(string toClean)
    {
        string[] cleanedString = toClean.Split(':');
        string[] stringArray = cleanedString[1].Split(',', ';');
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = stringArray[i].Trim();
        }
        return stringArray;

    }

}