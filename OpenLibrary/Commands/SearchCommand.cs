using NLog;
using OpenLibrary.Services;
using OpenLibrary.ViewModels;
using System;
using System.Windows;

namespace OpenLibrary.Commands
{
    public class SearchCommand : CommandBase
    {
        private readonly SearchLibraryViewModel searchLibrary;

        private readonly ILibraryService libraryService;

        Logger log = LogManager.GetCurrentClassLogger();

        public SearchCommand(SearchLibraryViewModel searchLibrary, ILibraryService libraryService)
        {
            this.searchLibrary = searchLibrary;
            this.libraryService = libraryService;   
        }

        public async override void Execute(object? parameter)
        {
            if (string.IsNullOrWhiteSpace(searchLibrary.SearchTerm))
            {
                MessageBox.Show("Searchbar cannot be empty.");
                log.Error(new Exception(), "Searchbar cannot be empty.");
            }
            else
            {
                searchLibrary.Books.Clear();
                var result = await libraryService.SearchBook(searchLibrary.SearchTerm, searchLibrary.SearchByTitle, searchLibrary.SearchByAuthor);

                foreach (var book in result)
                {
                    var bookModel = new BookViewModel(book);
                    searchLibrary.Books.Add(bookModel);
                }
            }
        }
    }
}
