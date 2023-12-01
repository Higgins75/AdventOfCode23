using System;
using System.ComponentModel;
using System.IO;

class Program
{
   
    static void Main()
    {
        stringParse p = new stringParse();

        int totalInputs = 0;
        int total = 0;
        List<string> inputStrings = new List<string>();

        try
        {
            using (StreamReader sr = new StreamReader("day_1.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    inputStrings.Add(line);
                    totalInputs += 1;
                }
            }
        }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        
        string [] ArrayList = inputStrings.ToArray();


        for (int i = 0; i < ArrayList.Length; i++)
        {
            total += p.parseString(ArrayList[i]);
        }




        Console.WriteLine(total);
    }
}