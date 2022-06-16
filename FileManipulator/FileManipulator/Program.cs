using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace FileManipulator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var fileService = new FileService();
            fileService.RequestPath();
            var prepender = new FilePrepender(fileService.GetPath());
            var appender = new FileAppender(fileService.GetPath());
            fileService.ModifyFile(prepender);
            fileService.ModifyFile(appender);
        }
    }
}

