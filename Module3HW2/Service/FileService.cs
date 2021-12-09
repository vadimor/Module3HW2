using System.IO;
using Module3HW2.Service.Abstract;

namespace Module3HW2.Service
{
    public class FileService : IFileService
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
