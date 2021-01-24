using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Avalonia.Media.Imaging;
using Bitmap = Avalonia.Media.Imaging.Bitmap;

namespace Aaberg.Commander.Models
{
    public class FileSystemInfoModel
    {
        private FileSystemInfo fileSystemInfo;

        public FileSystemInfoModel(FileSystemInfo fileSystemInfo)
        {
            this.fileSystemInfo = fileSystemInfo;
        }

        public FileSystemInfo FileSystemInfo => fileSystemInfo;

        public string Name => FileSystemInfo.Name;

        public IBitmap Icon
        {
            get
            {
                var icon = System.Drawing.Icon.ExtractAssociatedIcon(fileSystemInfo.FullName);
                var stream = new MemoryStream();
                icon.ToBitmap().Save(stream, ImageFormat.Bmp);
                stream.Flush();
                stream.Position = 0;

                return new Bitmap(stream);
            }
        }

        
    }
}