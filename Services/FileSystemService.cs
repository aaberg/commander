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

        public IEnumerable<IFileSystemEntry> GetEntriesInDirectory(DirectoryEntry dir)
        {
            return 
                dir.DirectoryInfo.GetDirectories()
                .Where(dirInfo => (dirInfo.Attributes & FileAttributes.Hidden) == 0)
                .Select(dirInfo => new DirectoryEntry(dirInfo))
                .Cast<IFileSystemEntry>()
                .Concat(dir.DirectoryInfo.GetFiles().Select(fileInfo => new FileEntry(fileInfo)));
        }
    }
}