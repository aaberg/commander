using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Aaberg.Commander.Models;
using Aaberg.Commander.Services;
using ReactiveUI;

namespace Aaberg.Commander.ViewModels
{
    public class DirectoryPaneViewModel : ViewModelBase
    {
        private DirectoryEntry directory;

        public DirectoryPaneViewModel(string initialPath)
        {
            directory = new DirectoryEntry(new DirectoryInfo(initialPath));
        }

        public DirectoryEntry Directory
        {
            get => directory;
            set
            {
                this.RaiseAndSetIfChanged(ref directory, value);
                this.RaisePropertyChanged(nameof(Entries));
                this.RaisePropertyChanged(nameof(InitialSelectedIndex));
            }
        }
        
        public IEnumerable<IFileSystemEntry> Entries => new FileSystemService().GetEntriesInDirectory(Directory);
        
        public int InitialSelectedIndex => 0;

        public void GoOneDirectoryUp()
        {
            if (Directory.DirectoryInfo.Parent != null)
            {
                Directory = new DirectoryEntry(Directory.DirectoryInfo.Parent);
            }
        }
    }
}