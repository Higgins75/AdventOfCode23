using System;
using System.Text.RegularExpressions;

class Operations
{
    public Map getMap(string input)
    {
        Map mapToReturn = new Map();
        
        // Define the regex pattern
        string pattern = @"\b\w{3}\b";

        // Create a Regex object
        Regex regex = new Regex(pattern);

        // Match the pattern in the input string
        MatchCollection matches = regex.Matches(input);

        mapToReturn.indexOfString = matches[0].Value;
        mapToReturn.lString = matches[1].Value;
        mapToReturn.rString = matches[2].Value;

        return mapToReturn;
    }
}