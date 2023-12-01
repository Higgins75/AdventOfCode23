class Converters
{
    //converts from ASCII to actual characters
    public int ChartoInt(char Char)
    {
        int Value = Convert.ToInt32(Char-48);
        return Value;
    }

    //ensures any ASCII is a number, and not a different character
    public bool isNumber(int test)
    {
        if (test > 0 & test < 10)
        {
            return true;
        }
        return false;
    }
}