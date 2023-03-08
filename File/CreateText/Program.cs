using CreateText;

string path = Directory.GetCurrentDirectory() + $"{Path.DirectorySeparatorChar}Text.txt";
FileCreateText.CreateText(path);
FileCreateText.ReadText(path);

string path2 = Directory.GetCurrentDirectory() + $"{Path.DirectorySeparatorChar}Text_Two.txt";
var file = new FileInfo(path2);
FileInfoCreateText.CreateText(file);
FileInfoCreateText.ReadText(file);

string path3 = Directory.GetCurrentDirectory() + $"{Path.DirectorySeparatorChar}Text_Three.txt";
FileCreate.Create(path3);
FileCreate.Read(path3);

string path4 = Directory.GetCurrentDirectory() + $"{Path.DirectorySeparatorChar}Text_Four.txt";
var file2 = new FileInfo(path4);
FileInfoCreate.Create(file2);
FileInfoCreate.Read(file2);