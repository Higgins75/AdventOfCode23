using System;
using System.ComponentModel;
using System.IO;

class Program
{
   
    static void Main()
    {
        //initialises functions
        stringParse p = new stringParse();
        fileReader f = new fileReader();

        //init total to return
        int total = 0;


        //creates a list of strings from the file given
        string[] ArrayList = f.readFile("day_1.txt");


        //iterates through the list, adding the digits to the total
        for (int i = 0; i < ArrayList.Length; i++)
        {
            // Console.WriteLine(i);
            total += p.parseString(ArrayList[i]);
        }

        //prints total
        Console.WriteLine(total);
    }
}