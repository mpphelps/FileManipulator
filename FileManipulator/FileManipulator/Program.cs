using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter in path name of files to rename: ");
            var path = Console.ReadLine();
            Console.WriteLine(Directory.Exists(path) ? "Valid Path Entered" : "InValid Path Entered, Exiting Program");
            //var path = Path.Combine(new[]{ Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Temp"});
            if (path == null || !(Directory.Exists(path))) return;
            var directoryInfo = new DirectoryInfo(path);
            foreach (var fileInfo in directoryInfo.GetFiles())
            {
                Console.WriteLine($"Renaming: {Path.GetFileNameWithoutExtension(fileInfo.FullName)}");
                File.Move(fileInfo.FullName, fileInfo.Directory.FullName +
                                             Path.DirectorySeparatorChar +
                                             Path.GetFileNameWithoutExtension(fileInfo.FullName) +
                                             "2" +
                                             fileInfo.Extension);
            }
        }
    }
}

