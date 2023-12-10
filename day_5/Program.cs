using System.Runtime.CompilerServices;
using System;
using System.Runtime;

class day_5_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        Operations o = new Operations();

        string[] testString = f.readFile("day_5_test.txt");

        // string seeds = "seeds:";
        var seeds = new List<int>();

        foreach (string item in testString)
        {
            if (item.Contains("seeds:"))
            {
                seeds.AddRange(o.GenerateNumberList(item));
            }
        }
    }
}