using System;
using Aaberg.Commander.Models;
using Aaberg.Commander.ViewModels;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;

namespace Aaberg.Commander.Views
{
    public class DirectoryPaneView : UserControl
    {
        public DirectoryPaneView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        public void OnKeyDown(object o, KeyEventArgs e)
        {
            
            if (e.Key == Key.Return && e.Source is ListBoxItem {DataContext: DirectoryEntry directoryEntry})
            {
                ((DirectoryPaneViewModel)DataContext)!.Directory = directoryEntry;
            }

            if (e.Key == Key.Back)
            {
                (DataContext as DirectoryPaneViewModel)?.GoOneDirectoryUp();
            }


        }
    }
}