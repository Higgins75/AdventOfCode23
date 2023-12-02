using System.Globalization;

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
        int secondDigitPosition = testInput.Length;

        
        bool firstDigitLocated = false;
        bool secondDigitLocated = false;

        string reverseInput = index.Reverse(testInput);

        while (firstDigitLocated == false)
        {
            for (int i = 0; i < testInput.Length; i++)
            {
                int testNum = c.ChartoInt(testInput[i]);
                int digitPosition = i;
                if (c.isNumber(testNum))
                {
                    firstDigit = testNum;
                    firstDigitPosition = i;
                    firstDigitLocated = true;
                    Console.WriteLine("first num is {0} at location {1}", firstDigit, firstDigitPosition);
                    break;
                }
            }
            Console.WriteLine("escape");
            firstDigitLocated = true;
        }

        while (secondDigitLocated == false)
        {
            for (int i = 0; i < testInput.Length; i++)
            {
                int testNum = c.ChartoInt(reverseInput[i]);
                int digitPosition = i;
                if (c.isNumber(testNum))
                {
                    secondDigit = testNum;
                    secondDigitPosition = i;
                    secondDigitLocated = true;
                    Console.WriteLine("second num is {0} at location {1}", secondDigit, secondDigitPosition);     
                    break;               
                }
            }
            Console.WriteLine("escape");                
            secondDigitLocated = true;
        }     


        string[] numberList = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
        string[] reverseNumberList = ["eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin"];

        for (int i = 0; i < numberList.Length; i++)
        {
            bool isPresent = testInput.Contains(numberList[i]);
            if (isPresent)
            {
                int digitPosition = testInput.IndexOf(numberList[i]);
                if (digitPosition < firstDigitPosition)
                {
                    firstDigit = i + 1;
                    firstDigitPosition = digitPosition;
                    Console.WriteLine("first num is {0} at location {1}", firstDigit, firstDigitPosition);
                }
            }
        }

        for (int i = 0; i < reverseNumberList.Length; i++)
        {
            bool isPresent = reverseInput.Contains(reverseNumberList[i]);
            if (isPresent)
            {
                int digitPosition = reverseInput.IndexOf(reverseNumberList[i]);
                if (digitPosition < secondDigitPosition)
                {
                    secondDigit = i + 1;
                    secondDigitPosition = digitPosition;
                    Console.WriteLine("second num is {0} at location {1}", secondDigit, secondDigitPosition);                     
                }
            }
        }

        return firstDigit * 10 + secondDigit;

    }
}