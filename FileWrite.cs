namespace ID;

public class FileWrite
{
    public void write(String file, String content)
    {
        File.WriteAllText(file, content);
    }
}