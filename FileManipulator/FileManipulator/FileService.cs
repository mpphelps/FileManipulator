using System;
using System.IO;

namespace FileManipulator
{
    public class FileService
    {
        private string _path;
        public void RequestPath()
        {
            Console.WriteLine("Enter in path name of files to rename: ");
            _path = Console.ReadLine();
            if (!(Directory.Exists(_path)))
                throw new InvalidOperationException("Invalid Pathname");
            Console.WriteLine(Directory.Exists(_path) ? "Valid Path Entered" : "InValid Path Entered, Exiting Program");
        }
        public string GetPath()
        {
            return _path;
        }
        public void ModifyFile(IFileNameModifier fileNameModifier)
        {
            Console.WriteLine($"Enter in {(fileNameModifier.ModifierType).ToLower()} for files: ");
            var stringModifier = Console.ReadLine();
            if (!(string.IsNullOrWhiteSpace(stringModifier)))
                fileNameModifier.ModifyFileNames(stringModifier);
        }
    }
}