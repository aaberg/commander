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
        private DirectoryInfo directory;
        private IFileSystemService fileSystemService;

        public DirectoryPaneViewModel(string initialPath)
        {
            directory = new DirectoryInfo(initialPath);
            fileSystemService = new FileSystemService();
        }

        public DirectoryInfo Directory
        {
            get => directory;
            set => this.RaiseAndSetIfChanged(ref directory, value);
        }

        public IEnumerable<FileSystemInfoModel> Entries => fileSystemService.GetEntriesInDirectory(Directory).Select(info => new FileSystemInfoModel(info));
    }
}