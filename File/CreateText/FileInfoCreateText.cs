namespace CreateText;
public static class FileInfoCreateText
{
    public static void CreateText(FileInfo file)
    {
        if (!file.Exists)
        {
            using StreamWriter sw = file.CreateText();
            sw.WriteLine("FileInfo.CreateText()");
            sw.WriteLine("Creates a StreamWriter that writes a new text file.");
        }
    }

    public static void AppendText(FileInfo file)
    {
        using StreamWriter sw = file.AppendText();
        sw.WriteLine("FileInfo.AppendText()");
        sw.Write("Creates a StreamWriter that appends text to the file represented");
        sw.WriteLine(" by this instance of the FileInfo.");
    }

    public static void ReadText(FileInfo file)
    {
        using StreamReader sr = file.OpenText();
        string str = string.Empty;

        while ((str = sr.ReadLine()) != null)
            Console.WriteLine(str);
    }
}
