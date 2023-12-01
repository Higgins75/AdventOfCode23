class stringParse
{   
    Converters c = new Converters();
    public int parseString(string testInput)
    {
        int firstDigit = 0;
        int secondDigit = 0;
        bool firstInput = true;
        
        for (int i = 0; i < testInput.Length; i++)
        {
            
            int testNum = c.ChartoInt(testInput[i]);
            if (c.isNumber(testNum) & firstInput == true)
            {
                firstDigit = testNum * 10;
                firstInput = false;
            }
            else if (c.isNumber(testNum) & firstInput == false)
            {
                secondDigit = testNum;
            }
        }
        return firstDigit + secondDigit;
    }
}