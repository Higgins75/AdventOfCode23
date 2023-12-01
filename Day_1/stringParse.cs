class stringParse
{   
    Converters c = new Converters();
    Index index = new Index();
    public int parseString(string testInput)
    {
        //initalise variables for use in for loop.
        int firstDigit = 0;
        int firstDigitPosition = testInput.Length;
        int secondDigit = 0;
        int secondDigitPosition = 0;

        
        for (int i = 0; i < testInput.Length; i++)
        {
            //init variable
            int testNum = c.ChartoInt(testInput[i]);
            int digitPosition = i;
            //find the first number and save as firstDigit. Ensure future numbers do not override this one
            if (c.isNumber(testNum) & index.checkFirst(firstDigitPosition, digitPosition))
            {
                firstDigit = testNum;
                firstDigitPosition = i;
                Console.WriteLine("First digit set to {0} at {1}", firstDigit, firstDigitPosition);
            }

            //overrides the secondDigit variable if a number is found after the first was located
            if (c.isNumber(testNum) & index.checkLast(secondDigitPosition, digitPosition))
            {
                secondDigit = testNum;
                secondDigitPosition = i;
                Console.WriteLine("Second digit set to {0} at {1}", secondDigit, secondDigitPosition);
            }
        }

        string[] numberList = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];

        for (int i = 0; i < numberList.Length; i++)
        {
            bool isPresent = testInput.Contains(numberList[i]);
            if (isPresent)
            {
                int digitPosition = testInput.IndexOf(numberList[i]);
                if (index.checkFirst(firstDigitPosition, digitPosition))
                {
                    firstDigit = i + 1;
                    firstDigitPosition = digitPosition;
                    Console.WriteLine("First digit set to {0} at {1}", firstDigit, firstDigitPosition);
                }
                if (index.checkLast(secondDigitPosition, digitPosition))
                {
                    secondDigit = i + 1;
                    secondDigitPosition = digitPosition;
                    Console.WriteLine("Second digit set to {0} at {1}", secondDigit, secondDigitPosition);
                }
            }
        }


        //catches if the second digit did not appear
        if (secondDigit == 0)
        {
            secondDigit = firstDigit;
        }

        //multiples digit 1 by 10, adds it to second digit to get a correct value. Returns out of function
        return firstDigit * 10 + secondDigit;
    }
}