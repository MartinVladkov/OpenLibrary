using OpenLibrary.Services;

namespace OpenLibrary.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        ILibraryService libraryService;

        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(ILibraryService libraryService)
        {
            this.libraryService = libraryService;
            CurrentViewModel = new SearchLibraryViewModel(this.libraryService);
        }
    }
}
  