
using System.IO;
using System.Text;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string url = "C:\\Users\\mcarm\\Documents\\Visual Studio 2022\\f1.txt";
//var uri = new Uri(url); 
//var path = Path.GetFileName(uri.AbsolutePath);
//TextWriter file = new StreamWriter(path);
//String msg = "";
//msg = Console.ReadLine();
//file.WriteLine(msg);

//file.Close();
//TextReader readingFile = new StreamReader(path);
//Console.WriteLine(readingFile.ReadLine());
//readingFile.Close();    
string path = "c:\\temp\\MyTest.txt";

try
{
    FileStream fs = File.Create(path);
    byte[] info = new UTF8Encoding(true).GetBytes("Hi!!");
    fs.Write(info, 0, info.Length);
    int l=info.Length;
    fs.Close();
    string info2 = "Hello!!";
    File.AppendAllText(path, info2);
    fs.Close();
    StreamReader sr = File.OpenText(path);
    Console.WriteLine(sr.ReadLine());
    sr.Close(); 
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
