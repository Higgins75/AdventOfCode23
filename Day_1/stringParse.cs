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
        int secondDigitPosition = 0;
        int timesCommited = 0;


        for (int i = 0; i < testInput.Length; i++)
        {  
            //init variable
            int testNum = c.ChartoInt(testInput[i]);
            int digitPosition = i;
            //if a number is earlier than the saved first digit position, saves as first digit
            if (c.isNumber(testNum) & index.checkFirst(firstDigitPosition, digitPosition))
            {
                firstDigit = testNum;
                firstDigitPosition = i;
                timesCommited++;
                Console.WriteLine("First digit set to {0} at {1}", firstDigit, firstDigitPosition);
            }

            //if a number is later than the second digit saved position, saves as second digit
            if (c.isNumber(testNum) & index.checkLast(secondDigitPosition, digitPosition))
            {
                secondDigit = testNum;
                secondDigitPosition = i;
                timesCommited++;
                Console.WriteLine("Second digit set to {0} at {1}", secondDigit, secondDigitPosition);
            }
        }

        string[] numberList = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];

        for (int i = 0; i < numberList.Length; i++)
        {
            bool isPresent = testInput.Contains(numberList[i]);
            if (isPresent)
            {
                int numberOfOccurances = index.CountWords(testInput, numberList[i]);
                Console.WriteLine("Number of occurances is {0}", numberOfOccurances);
                string tempTestInput = testInput;
                for (int j = 0; j < numberOfOccurances; j++)
                {
                    int digitPosition = tempTestInput.IndexOf(numberList[i]);
                    Console.WriteLine("Digit positon is {0}", digitPosition);
                    if (index.checkFirst(firstDigitPosition, digitPosition))
                    {
                        firstDigit = i + 1;
                        firstDigitPosition = digitPosition;
                        timesCommited++;
                        Console.WriteLine("First digit set to {0} at {1}", firstDigit, firstDigitPosition);
                    }
                    if (index.checkLast(secondDigitPosition, digitPosition))
                    {
                        secondDigit = i + 1;
                        secondDigitPosition = digitPosition;
                        timesCommited++;
                        Console.WriteLine("Second digit set to {0} at {1}", secondDigit, secondDigitPosition);
                    }            
                    tempTestInput = tempTestInput.Substring(digitPosition + numberList[i].Length); 
                    Console.WriteLine("occured");    
                }

            }
        }

        //multiples digit 1 by 10, adds it to second digit to get a correct value. Returns out of function
        if (timesCommited == 1)
        {
            return firstDigit;
        }
        else return firstDigit * 10 + secondDigit;
    }
}