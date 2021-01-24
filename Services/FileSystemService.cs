using System.Collections.Generic;
using System.IO;
using System.Linq;
using Aaberg.Commander.Models;

namespace Aaberg.Commander.Services
{
    public class FileSystemService : IFileSystemService
    {
        public DirectoryInfo GetDirectory(string path)
        {
            return new(path);
        }

        public IEnumerable<FileSystemInfo> GetEntriesInDirectory(DirectoryInfo dir)
        {
            return dir.GetDirectories().Cast<FileSystemInfo>().Concat(dir.GetFiles());
            
        }
    }
}