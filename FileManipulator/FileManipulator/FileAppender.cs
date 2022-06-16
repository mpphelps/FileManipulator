﻿using System;
using System.IO;

namespace FileManipulator
{
    partial class Program
    {
        public class FileAppender : IFileNameModifier
        {
            private readonly string _path;

            public FileAppender(string path)
            {
                if (Directory.Exists(path))
                {
                    _path = path;
                }
                else
                {
                    throw new InvalidOperationException("Invalid Pathname");
                }
            }
            public void ModifyFileNames(string stringModifier)
            {
                if (_path == null || !(Directory.Exists(_path))) return;
                var directoryInfo = new DirectoryInfo(_path);
                foreach (var fileInfo in directoryInfo.GetFiles())
                {
                    Console.WriteLine($"Renaming: {Path.GetFileNameWithoutExtension(fileInfo.FullName)}");
                    File.Move(fileInfo.FullName, fileInfo.Directory.FullName +
                                                 Path.DirectorySeparatorChar +
                                                 Path.GetFileNameWithoutExtension(fileInfo.FullName) +
                                                 stringModifier +
                                                 fileInfo.Extension);
                }
            }
        }
    }
}