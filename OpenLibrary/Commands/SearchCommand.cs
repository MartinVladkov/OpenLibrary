using OpenLibrary.Services;
using OpenLibrary.ViewModels;

namespace OpenLibrary.Commands
{
    public class SearchCommand : CommandBase
    {
        private readonly SearchLibraryViewModel searchLibrary;

        private readonly ILibraryService libraryService;

        public SearchCommand(SearchLibraryViewModel searchLibrary, ILibraryService libraryService)
        {
            this.searchLibrary = searchLibrary;
            this.libraryService = libraryService;   
        }

        public override void Execute(object? parameter)
        {
            searchLibrary.Books.Clear();
            var result = libraryService.SearchBook(searchLibrary.SearchTerm, searchLibrary.SearchByTitle, searchLibrary.SearchByAuthor);

            foreach (var book in result)
            {
                var bookModel = new BookViewModel(book);
                searchLibrary.Books.Add(bookModel);
            }
        }
    }
}
