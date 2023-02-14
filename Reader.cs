using System.Text.RegularExpressions;

namespace ID;

public class FileReader
{
    protected String[] separators = { "\r\n", "\r", "\n" };

    public List<ID> read(string file)
    {
        if (! File.Exists(file))
            throw new Exception("File " + file + " does not exist.");
        String content = File.ReadAllText(file);
        String[] idNumbers = content.Split(this.separators, StringSplitOptions.None);
        return cleanIdNumbers(idNumbers);
    }

    protected List<ID> cleanIdNumbers(string[] idNumbers)
    {
        List<ID> validIdNumbers = new List<ID>{};
        foreach (String idNumber in idNumbers)
            if (idNumber.Length == 13 && Regex.IsMatch(idNumber, @"^[0-9]+$"))
                validIdNumbers.Add(new ID(idNumber));
            else
                Console.WriteLine("Error: " + idNumber);
        return validIdNumbers;     
    }
}