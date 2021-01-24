namespace Aaberg.Commander.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            //LeftPane = new DirectoryPaneViewModel("C:\\temp");
            LeftPane = new DirectoryPaneViewModel("/temp");
        }

        public DirectoryPaneViewModel LeftPane { get; }
    }
}
