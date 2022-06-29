using System;
using System.IO;

namespace FileManipulator
{
    public class FileService
    {
        private string _path;
        private readonly IPathRequester _pathRequester;

        public FileService(IPathRequester pathRequester)
        {
            _pathRequester = pathRequester;
        }
        public void RequestPath()
        {
            _path = _pathRequester.ManuallyEnterPath();
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

    public interface IPathRequester
    {
        string ManuallyEnterPath();
        string GraphicallyEnterPath();
    }

    public class PathRequester : IPathRequester
    {
        public string ManuallyEnterPath()
        {
            Console.WriteLine("Enter in path name of files to rename: ");
            var path = Console.ReadLine();

            return Directory.Exists(path) ? path : throw new InvalidOperationException("Invalid Pathname");
        }

        public string GraphicallyEnterPath()
        {
            //Implementation Needed
            throw new NotImplementedException();
        }
    }

    public class TestPathRequester : IPathRequester
    {
        public string TestPathName { get; set; }
        public string ManuallyEnterPath()
        {
            return TestPathName;
        }

        public string GraphicallyEnterPath()
        {
            return TestPathName;
        }
    }
}