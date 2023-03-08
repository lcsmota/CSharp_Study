namespace CreateText;

public static class FileCreateText
{
    public static void CreateText(string path)
    {
        if (!File.Exists(path))
        {
            using StreamWriter sw = File.CreateText(path);
            sw.WriteLine("File.CreateText(path)");
            sw.WriteLine("Creates or opens a file for writing UTF-8 encoded text.");
            sw.WriteLine("If the file already exists, its contents are overwritten.");
        }
    }

    public static void AppendText(string path)
    {
        using StreamWriter sw = File.AppendText(path);
        sw.WriteLine("File.AppendText(path)");
        sw.Write("Creates a StreamWriter that appends UTF-8 encoded text to an existing file,");
        sw.WriteLine(" or to a new file if the specified file does not exist.");
    }

    public static void ReadText(string path)
    {
        using StreamReader sr = File.OpenText(path);
        string str = string.Empty;

        while ((str = sr.ReadLine()) != null)
            Console.WriteLine(str);
    }
}
