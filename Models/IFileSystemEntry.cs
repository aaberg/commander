using Avalonia.Media.Imaging;

namespace Aaberg.Commander.Models
{
    public interface IFileSystemEntry
    {
        public string FullName { get; }
        public string Name { get; }
        public IBitmap Icon { get; }
    }
}