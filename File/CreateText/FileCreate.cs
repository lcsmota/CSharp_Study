using System.Text;

namespace CreateText;

public static class FileCreate
{
    public static void Create(string path)
    {
        using FileStream fs = File.Create(path);

        byte[] info = new UTF8Encoding(true).GetBytes("File.Create(path) - Creates or overwrites a file in the specified path.");

        fs.Write(info, 0, info.Length);
    }

    public static void Read(string path)
    {
        using StreamReader sr = File.OpenText(path);

        string str = string.Empty;

        while ((str = sr.ReadLine()) != null)
            Console.WriteLine(str);
    }
}
