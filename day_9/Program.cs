using System.Globalization;

class day_9_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        Operations o = new Operations();

        string[] inputText = f.readFile("day_9.txt");
        int extrapolatedSum = 0;

        foreach (string history in inputText)
        {
            int extrapolatedValue = 0;
            List<List<int>> numberLists = new List<List<int>>();
            int count = 0;
            
            numberLists.Add(o.GenerateNumberList(history));

            while (!o.CheckAllZeros(o.extrapolate(numberLists[count])))
            {
                numberLists.Add(o.extrapolate(numberLists[count]));
                count++;
            }
            numberLists.Add(o.extrapolate(numberLists[count]));            
            
            
            for (int i = numberLists.Count - 1;  i > -1; i--)
            {
                List<int> listToCheck = numberLists[i];
                extrapolatedValue += listToCheck[listToCheck.Count - 1];
            }
            extrapolatedSum += extrapolatedValue;
        }
        Console.WriteLine(extrapolatedSum);
    }
}