using System;
using System.IO;
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
            set => this.RaiseAndSetIfChanged(ref directory, value);
        }

        public void Test()
        {
            Console.WriteLine("Test");
        }

        public void GoOneDirectoryUp()
        {
            if (Directory.DirectoryInfo.Parent != null)
            {
                Directory = new DirectoryEntry(Directory.DirectoryInfo.Parent);
            }
        }
    }
}