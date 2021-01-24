using System.IO;
using Aaberg.Commander.Services;
using Avalonia.Media.Imaging;

namespace Aaberg.Commander.Models
{
    public class FileEntry : IFileSystemEntry
    {
        private static readonly IconService IconService = new();
        
        public FileEntry(FileInfo fileInfo)
        {
            FileInfo = fileInfo;
        }

        public string Name => FileInfo.Name;
        public IBitmap Icon => IconService.GetFileEntryIcon(this);
        public string FullName => FileInfo.FullName;
        public FileInfo FileInfo { get; }
    }
}