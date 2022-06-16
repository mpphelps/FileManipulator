using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var fileService = new FileService();
            fileService.RequestPath();
            fileService.PrependString();
            fileService.AppendString();
        }
    }
}

