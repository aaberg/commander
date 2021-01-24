using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Aaberg.Commander.Services;
using Avalonia;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace Aaberg.Commander.Models
{
    public class DirectoryEntry : IFileSystemEntry
    {
        public DirectoryEntry(DirectoryInfo directoryInfo)
        {
            DirectoryInfo = directoryInfo;
        }
        
        public DirectoryInfo DirectoryInfo { get; }
        public string Name => DirectoryInfo.Name;
        public string FullName => DirectoryInfo.FullName;

        public IEnumerable<IFileSystemEntry> Entries => new FileSystemService().GetEntriesInDirectory(this); 

        public IBitmap Icon
        {
            get
            {
                var assets = AvaloniaLocator.Current.GetService<IAssetLoader>();
                return new Bitmap(assets.Open(new Uri("avares://aaberg-commander/Assets/Icons/folder.png")));
            }
        }

        
    }
}