using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace FileManipulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pathRequester = new PathRequester();
            var fileService = new FileService(pathRequester);
            fileService.RequestPath();
            var prepender = new FilePrepender(fileService.GetPath());
            var appender = new FileAppender(fileService.GetPath());
            fileService.ModifyFile(prepender);
            fileService.ModifyFile(appender);
            Console.WriteLine("End of Program");
        }
    }
}

