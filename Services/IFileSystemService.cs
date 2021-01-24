using System.Collections.Generic;
using System.IO;
using Aaberg.Commander.Models;

namespace Aaberg.Commander.Services
{
    public interface IFileSystemService
    {
        DirectoryInfo GetDirectory(string path);

        IEnumerable<FileSystemInfo> GetEntriesInDirectory(DirectoryInfo dirPath);
    }
}