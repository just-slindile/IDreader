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

    protected List<ID> cleanIdNumbers(String[] idNumbers)
    {
        List<ID> validIdNumbers = new List<ID> {};
        foreach (String idNumber in idNumbers)
            if (idNumber.Length == 13)
                validIdNumbers.Add(new ID(idNumber));
        return validIdNumbers;
    }
}