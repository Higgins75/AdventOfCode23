using System;

class Program
{
   
    static void Main()
    {
        stringParse p = new stringParse();
        
        int total = 0;
        string testInput  = "1a23bc";
        string secondTestInput = "pqr3stu8vwx";

        total += p.parseString(testInput);
        total += p.parseString(secondTestInput);


        Console.WriteLine(total);
    }


}