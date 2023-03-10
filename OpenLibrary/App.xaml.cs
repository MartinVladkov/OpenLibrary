using OpenLibrary.Services;
using OpenLibrary.ViewModels;
using System.Windows;

namespace OpenLibrary
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            var libraryService = new LibraryService();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(libraryService)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
