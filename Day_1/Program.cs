using System;
using System.ComponentModel;
using System.IO;

class Program
{
   
    static void Main()
    {
        stringParse p = new stringParse();
        fileReader f = new fileReader();

        int total = 0;

        string[] ArrayList = f.readFile("day_1.txt");

        for (int i = 0; i < ArrayList.Length; i++)
        {
            total += p.parseString(ArrayList[i]);
        }




        Console.WriteLine(total);
    }
}