using System;
using System.IO;

namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var path = Directory.GetCurrentDirectory();
            //SpecialDirectory();
            //SpecialPath();
            //Splitpath();
            //JoinPath();
            //getFileextention();
            //GetDirInfo();
            //getDirectories();
            //SearchInDirectories();
            //FindOrCreate();
            //readDataFromFile();
            writeOnFile();

        }

        static void SpecialDirectory()
        {
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }
        static void SpecialPath()
        {
            Console.WriteLine($"dir{Path.DirectorySeparatorChar}dir2");

            // mydir/ -> Windows 
            // mydir\dir2 -> macOs
        }
        static void Splitpath()
        {
            var path = Directory.GetCurrentDirectory().Split(Path.DirectorySeparatorChar);
        }
        static void JoinPath()
        {
            var path = Path.Combine("C:", "logs");
        }
        static void getFileextention()
        {
            var path = Path.GetExtension("vendita.json");
        }

        static void GetDirInfo()
        {
            string path = Directory.GetCurrentDirectory();

            DirectoryInfo dInfo = new DirectoryInfo(path);

            foreach (DirectoryInfo info in dInfo.GetDirectories())
                Console.WriteLine(info.Parent);

            foreach (FileInfo file in dInfo.GetFiles())
                Console.WriteLine(file);
        }

        static void getDirectories()
        {
            string path = Directory.GetCurrentDirectory();
            var dirs = Directory.GetDirectories(path);

            foreach (var d in dirs)
                Console.WriteLine(d);


            var files = Directory.GetFiles(@"C:\logs");
            foreach (var f in files)
                Console.WriteLine(f);
        }
        static void SearchInDirectories()
        {
            var data = Directory.EnumerateFiles(@"C:\logs", "*.txt", SearchOption.TopDirectoryOnly);

            foreach (var file in data)
                Console.WriteLine(file);
        }
        static void FindOrCreate()
        {
            DirectoryInfo info = new DirectoryInfo(@"c:\pippo");
            if (info.Exists)
            {
                Console.WriteLine(info.FullName);
                Console.WriteLine(info.FullName);
                Console.WriteLine(info.Parent);

            }
            else
            {
                info.Create();
            }
        }
        static void readDataFromFile()
        {
            var text = File.ReadAllText($"C:{Path.DirectorySeparatorChar}logs{Path.DirectorySeparatorChar}greeting.txt");
            Console.WriteLine(text);
        }
        static void writeOnFile()
        {
            DirectoryInfo info = new DirectoryInfo(@"c:\logs");
            string[] s = new string[3] { "Hello by Bruno2", "Hello bruno 3", "Hello bruno3" };
            File.AppendAllLines(Path.Combine(info.FullName, "greeting.txt"), s);
        }
        static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            // Chekc if the target directory exists, if not , create

            //Copy each file into it's new Directory 

            //
        }

    }
}
