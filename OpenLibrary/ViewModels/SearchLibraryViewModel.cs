using OpenLibrary.Commands;
using OpenLibrary.Services;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace OpenLibrary.ViewModels
{
    public class SearchLibraryViewModel : ViewModelBase
    {
        private string searchTerm;
        public string SearchTerm
        {
            get { return searchTerm; }
            set
            { 
                if (string.IsNullOrWhiteSpace(value))
                {
                    searchTerm = value;
                    throw new ArgumentException("Searchbar cannot be empty.");
                }
               
                searchTerm = value;
                OnPropertyChanged(nameof(SearchTerm));
            }
        }

        private bool searchByTitle = true;
        public bool SearchByTitle
        {
            get { return searchByTitle; }
            set
            {
                searchByTitle = value;
                OnPropertyChanged(nameof(SearchByTitle));
            }
        }

        private bool searchByAuthor;
        public bool SearchByAuthor
        {
            get { return searchByAuthor; }
            set
            {
                searchByAuthor = value;
                OnPropertyChanged(nameof(SearchByAuthor));
            }
        }

        private readonly ILibraryService libraryService;

        private readonly ObservableCollection<BookViewModel> books = new ObservableCollection<BookViewModel>();

        public ObservableCollection<BookViewModel> Books => books;

        public ICommand SearchCommand { get; }

        public SearchLibraryViewModel() { }

        public SearchLibraryViewModel(ILibraryService libraryService) 
        {
            this.libraryService = libraryService;

            SearchCommand = new SearchCommand(this, libraryService);
        }
    }
}
