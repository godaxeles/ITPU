using System.Linq;
using Naming.Task5.ThirdParty;

namespace Naming.Task5
{
    public class FileExtension : IPredicate<string>
    {
        private readonly string[] _fileNames;

        public FileExtension(string[] fileNames)
        {
            _fileNames = fileNames;
        }

        public bool Test(string fileName)
        {
            fileName = fileName.ToLower();
            return _fileNames.Any(fileName.EndsWith);
        }
    }
}
