using OpenLibrary.Models;
using OpenLibrary.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OpenLibrary.ViewModels
{
    public class SearchLibraryViewModel : ViewModelBase
    {
        private readonly ILibraryService libraryService;

        private readonly ObservableCollection<BookListViewModel> books = new ObservableCollection<BookListViewModel>();

        public IEnumerable<BookListViewModel> Books => books;

        public ICommand SearchCommand { get; }

        public SearchLibraryViewModel(ILibraryService libraryService)
        {
            this.libraryService = libraryService;

            var booksList = CallService().Result;

            foreach (var book in booksList.docs)
            {
                var tempBook = new Book { title = book.title, author_name = book.author_name };
                var bookModel = new BookListViewModel(tempBook);
                books.Add(bookModel);
            }
            var a = 0;

        }

        public async Task<BooksList> CallService()
        {
            var booksList = await libraryService.GetApiResponse();

            return booksList;
        }
        
        //pri kommanda (search button) vikame getApiResponse sus search query-to i populvame spisuka sus vurnatiq response
    }
}
