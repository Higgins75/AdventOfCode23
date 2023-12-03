class fileReader
{
    public string[] readFile(string fileName)
    {
        //creates a List to input file lines into
        List<string> inputStrings = new List<string>();

        try
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;

                //iterates over file, adding each line to the List as a string
                while ((line = sr.ReadLine()) != null)
                {
                    inputStrings.Add(line);
                }
            }
        }
        //catch
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        
        //returns the list, as an array of strings for easier functions later
        return inputStrings.ToArray();
    }
}