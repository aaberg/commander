using System;
using Aaberg.Commander.Models;
using Aaberg.Commander.ViewModels;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.LogicalTree;
using Avalonia.Markup.Xaml;
using Splat;

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
            
            if (e.Key == Key.Return && e.Source is ListBoxItem {DataContext: DirectoryEntry directoryEntry} listBoxItem)
            {
                var listbox = (ListBox) listBoxItem.Parent;
                ((DirectoryPaneViewModel)DataContext)!.Directory = directoryEntry;
                    ResetFocus(listbox);
            }

            if (e.Key == Key.Back)
            {
                (DataContext as DirectoryPaneViewModel)?.GoOneDirectoryUp();
            }
        }

        public void ResetFocus(ListBox listBox)
        {
            if (listBox == null) 
                return;
            
            using var childrenEnumerator = listBox.GetLogicalChildren().GetEnumerator();
            if (!childrenEnumerator.MoveNext()) return;
            
            var item = childrenEnumerator.Current;
            if (item is IControl control)
            {
                control.Focus();
            }

        }
    }
}