using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class day_10_program
{
    static void Main()
    {
        fileReader f = new fileReader();
        string[] input = f.readFile("day_10.txt");
        var startingLocation = (y: 0, x: 0, direction: 0);
        int stepsTaken = 0;
        bool pathComplete = false;


        int Startcount = 0;
        foreach (string line in input)
        {
            if (line.Contains("S"))
            {
                startingLocation = (Startcount, line.IndexOf("S"), 0);
                break;
            }
            Startcount++;    
        }

        

        startingLocation.direction++;
        if (positionIsViable(startingLocation, input));

        //intial move, check each direction, move in the first one possible.

        //every move thereafter. While !pathComplete check what character is in position and then move to next.
    }

    static bool isComplete(Tuple<int, int> location, string[] input)
    {
        if (input[location.Item1][location.Item2] == 'S')
        {
            return true;
        }
        else return false;
    }

    static bool positionIsViable((int y, int x, int direction) startingLocation, string[] input)
    {

        char[] North = {'|', 'F', '7', 'S'}; //direction 1
        char[] East = {'-', 'J', '7', 'S'}; //direction 2
        char[] South = {'|', 'J', 'L', 'S'}; //direction 3
        char[] West = {'-', 'F', 'L', 'S'}; //direction 4

        Console.WriteLine(startingLocation.x);

        switch (startingLocation.direction)
        {
            case 1:
            if (ArrayContains(North, input[startingLocation.y - 1] [startingLocation.x]))
            {
                return true;
            }
            break;

            case 2:
            if (ArrayContains(East, input[startingLocation.y] [startingLocation.x + 1]))
            {
                return true;
            }
            break;

            case 3:
            if (ArrayContains(South, input[startingLocation.y + 1] [startingLocation.x]))
            {
                return true;
            }            
            break;

            case 4:
            if (ArrayContains(West, input[startingLocation.y] [startingLocation.x - 1]))
            {
                return true;
            }
            break;
        }
        
        return false;
    }

    static (int y, int x, int direction) moveToNextPosition((int y, int x, int direction) startingLocation, string[] input)
    {
        var newPosition = startingLocation;
        
        if (positionIsViable(startingLocation, input))
        {
        
        }
        

        return newPosition;
    }

    static bool ArrayContains(char[] array, char target)
    {
        return Array.IndexOf(array, target) != -1;
    }
}