using System;
using System.IO;
using Avalonia;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using JetBrains.Annotations;

namespace Aaberg.Commander.Models
{
    public class ParentDirectoryEntry : DirectoryEntry
    {
        public ParentDirectoryEntry([NotNull] DirectoryInfo directoryInfo) : base(directoryInfo)
        {
        }
        
        public override string Name => "..";
        public override IBitmap Icon
        {
            get
            {
                var assets = AvaloniaLocator.Current.GetService<IAssetLoader>();
                return new Bitmap(assets.Open(new Uri("avares://aaberg-commander/Assets/Icons/parentfolder.png")));
            }
        }

        
    }
}