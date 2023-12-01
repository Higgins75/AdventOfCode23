class stringParse
{   
    Converters c = new Converters();
    public int parseString(string testInput)
    {
        //initalise variables for use in for loop.
        int firstDigit = 0;
        int secondDigit = 0;

        //bools to ensure system knows which number it is on
        bool firstInput = true;
        bool secondInput = false;
        
        for (int i = 0; i < testInput.Length; i++)
        {
            //init variable
            int testNum = c.ChartoInt(testInput[i]);

            //find the first number and save as firstDigit. Ensure future numbers do not override this one
            if (c.isNumber(testNum) & firstInput == true)
            {
                firstDigit = testNum;
                firstInput = false;
            }

            //overrides the secondDigit variable if a number is found after the first was located
            else if (c.isNumber(testNum) & firstInput == false)
            {
                secondDigit = testNum;
                secondInput = true;
            }
        }

        //catches if the second digit did not appear
        if (secondInput == false)
        {
            secondDigit = firstDigit;
        }

        //multiples digit 1 by 10, adds it to second digit to get a correct value. Returns out of function
        return firstDigit * 10 + secondDigit;
    }
}