using System;
using Aaberg.Commander.Models;
using Avalonia;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace Aaberg.Commander.Services
{
    public class IconService
    {
        private readonly IAssetLoader _assetLoader;

        public IconService()
        {
            _assetLoader = AvaloniaLocator.Current.GetService<IAssetLoader>();
        }

        public IBitmap GetFileEntryIcon(FileEntry fileEntry)
        {
            var fileInfo = fileEntry.FileInfo;

            var extension = fileInfo.Extension;

            if (string.IsNullOrWhiteSpace(extension) || extension == ".")
            {
                return LoadIcon("file.png");
            }

            return extension switch
            {
                ".exe" => LoadIcon("application.png"),
                ".dll" => LoadIcon("dll.png"),
                _ => LoadIcon("file.png")
            };
        }
        
        
        private IBitmap LoadIcon(string assetName)
        {
            return new Bitmap(_assetLoader.Open(GetUri(assetName)));
        }
        
        private static Uri GetUri(string assetName)
        {
            return new Uri($"avares://aaberg-commander/Assets/Icons/{assetName}");
        }
        
    }
}