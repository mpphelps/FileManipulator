using NUnit.Framework;

namespace FileManipulator.UnitTests
{
    [TestFixture]
    public class FileServiceTests
    {
        [Test]
        public void RequestPath_ValidPath_SavesPath()
        {
            var testPathRequester = new TestPathRequester
            {
                TestPathName = @"C:\Users\h111840\Documents\Temp"
            };
            var fileService = new FileService(testPathRequester);
            fileService.RequestPath();
            Assert.That(fileService.GetPath(), Is.EqualTo(testPathRequester.TestPathName));
        }

    }
}