namespace Aaberg.Commander.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            //LeftPane = new DirectoryPaneViewModel("C:\\temp");
            LeftPane = new DirectoryPaneViewModel("/");
            RightPane = new DirectoryPaneViewModel("/");
        }

        public DirectoryPaneViewModel LeftPane { get; }
        public DirectoryPaneViewModel RightPane { get; }
    }
}
