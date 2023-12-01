class Converters
{
    public int ChartoInt(char Char)
    {
        int Value = Convert.ToInt32(Char-48);
        return Value;
    }

    public bool isNumber(int test)
    {
        if (test > 0 & test < 10)
        {
            return true;
        }
        return false;
    }
}