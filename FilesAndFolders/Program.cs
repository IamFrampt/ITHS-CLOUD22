//PATH
Console.WriteLine("Path------------------------");
Console.WriteLine();

string path = Path.Combine("c:", "windows", "drivers", "test.txt");
Console.WriteLine(path);

var extension = Path.GetExtension(path);
Console.WriteLine(extension);

var fileName = Path.GetFileName(path);
Console.WriteLine(fileName);

var relativePath = Path.GetRelativePath("c:\\test\\hej", @"c:\test\hejsan");
Console.WriteLine(relativePath);
Console.WriteLine();

//Directory
Console.WriteLine("Directory-------------------");

var currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);

var subDirectories = Directory.GetDirectories(@"C:\");

foreach (string subdir in subDirectories)
    Console.WriteLine(subdir);

Console.WriteLine();

//Files
Console.WriteLine("Files-----------------------");
var files = Directory.GetFiles(@"C:\");

foreach (string f in files)
    Console.WriteLine(f);

Console.WriteLine();

//StreamWriter

//using (var writeFile = new StreamWriter("myFile.txt", append: true, System.Text.Encoding.ASCII))
//{
//    writeFile.WriteLine("Hello");
//    writeFile.WriteLine("World");
//    //writeFile.Close();
//}

//StreamReader
Console.WriteLine("StreamReader----------------");
using (var readFile = new StreamReader("myFile.txt"))
{
    while (!readFile.EndOfStream)
    {
        var currenLine = readFile.ReadLine();
        Console.WriteLine(currenLine);
        //readFile.Close();
    }
}

Console.WriteLine();

using(var stream = new FileStream("myFile.txt",FileMode.Open))
{
    var fileSize = (int)stream.Length;
    Console.WriteLine($"File size: {fileSize} bytes");

    byte[] data  = new byte[fileSize];

    stream.Read(data, 0, fileSize);

    //var dataString = String.Join(", ", data);
    //Console.WriteLine(dataString);

    foreach (byte b in data)
        Console.Write(b.ToString("X2") + " ");
}