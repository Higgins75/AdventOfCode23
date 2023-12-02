class Operations
{
    public int ChartoInt(char Char)
    {
        int Value = Convert.ToInt32(Char-48);
        return Value;
    }

    public int getTotal (string totalToGet)
    {
        int Length = totalToGet.Length;
        switch (Length)
        {
            case 1:
            return ChartoInt(totalToGet[0]);

            case 2:
            return (ChartoInt(totalToGet[0]) * 10) + ChartoInt(totalToGet[1]);

            default:
            return 0;
        }
    }

    public bool isNumber(int test)
    {
        if (test > 0 & test < 10)
        {
            return true;
        }
        return false;
    }


    public int redCubes(string input)
    {
        bool isPresent = input.Contains("red");
        if (isPresent)
        {
            string[] numInput = input.Split(' ');
            return getTotal(numInput[0]);
        }
        return 0;
    } 
   public int greenCubes(string input)
    {
        bool isPresent = input.Contains("green");
        if (isPresent)
        {
            string[] numInput = input.Split(' ');            
            return getTotal(numInput[0]);
        }
        return 0;
    }
    

    public int blueCubes(string input)
    {
        bool isPresent = input.Contains("blue");
        if (isPresent)
        {
            string[] numInput = input.Split(' ');            
            return getTotal(numInput[0]);
        }
        return 0;
    }
}