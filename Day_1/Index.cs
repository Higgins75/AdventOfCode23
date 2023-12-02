public class Index
{
    public int CountWords(string text, string word) {
        int count = (text.Length - text.Replace(word, "").Length) / word.Length;
        return count;
    }

public string Reverse(string text)
{
    if (text == null) return null;
    char[] array = text.ToCharArray();
    Array.Reverse(array);
    return new String(array);
}
}