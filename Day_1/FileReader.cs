class fileReader
{
    public string[] readFile(string fileName)
    {
        List<string> inputStrings = new List<string>();

        try
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    inputStrings.Add(line);
                }
            }
        }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        
        return inputStrings.ToArray();
    }
}