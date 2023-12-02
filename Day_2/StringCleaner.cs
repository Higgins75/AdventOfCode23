public class stringCleaner
{
    public string[] cleanString(string toClean)
    {
        string[] cleanedString = toClean.Split(':');
        string[] stringArray = cleanedString[1].Split(',', ';');
        return stringArray;

    }

}