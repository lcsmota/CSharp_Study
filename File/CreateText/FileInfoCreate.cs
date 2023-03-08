using System.Text;

namespace CreateText;

public static class FileInfoCreate
{
    public static void Create(FileInfo file)
    {
        if (!file.Exists)
        {
            using FileStream fs = file.Create();

            byte[] info = new UTF8Encoding(true).GetBytes("FileInfo.Create() - Creates a file.");

            fs.Write(info, 0, info.Length);
        }
    }

    public static void Read(FileInfo file)
    {
        using StreamReader sr = file.OpenText();

        string str = string.Empty;

        while ((str = sr.ReadLine()) != null)
            Console.WriteLine(str);
    }
}
