using OpenLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
  