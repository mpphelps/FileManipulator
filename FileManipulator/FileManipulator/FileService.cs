using System;
using System.IO;

namespace FileManipulator
{
    partial class Program
    {
        public class FileService
        {
            private string _path;
            private string _prependString;
            private string _appendString;
            public void RequestPath()
            {
                Console.WriteLine("Enter in path name of files to rename: ");
                _path = Console.ReadLine();
                if (!(Directory.Exists(_path)))
                    throw new InvalidOperationException("Invalid Pathname");
                Console.WriteLine(Directory.Exists(_path) ? "Valid Path Entered" : "InValid Path Entered, Exiting Program");
            }

            public void PrependString()
            {
                Console.WriteLine("Enter in prepend for files: ");
                var prependString = Console.ReadLine();
                if (!(string.IsNullOrWhiteSpace(prependString)))
                {
                    var prepender = new FilePrepender(_path);
                    prepender.ModifyFileNames(prependString);
                }
            }

            public void AppendString()
            {
                Console.WriteLine("Enter in append for files: ");
                var appendString = Console.ReadLine();
                if (!(string.IsNullOrWhiteSpace(appendString)))
                {
                    var appender = new FileAppender(_path);
                    appender.ModifyFileNames(appendString);
                }
            }

        }
    }
}