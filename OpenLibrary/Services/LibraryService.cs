using OpenLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenLibrary.ViewModels;

namespace OpenLibrary.Services
{
    public class LibraryService : ILibraryService
    {
        private static readonly HttpClient Client = new HttpClient();

        private async Task<string> GetApiResponse(string connectionString)
        {
            string response = Client.GetStringAsync(connectionString).Result;

            return response;
        }

        public void SearchBook(SearchLibraryViewModel searchLibrary)
        {
            var query = searchLibrary.SearchTerm.Replace(" ", "+");

            string connectionString = "";
            string baseUrl = "";

            if (searchLibrary.SearchByAuthor == true)
            {
                baseUrl = "http://openlibrary.org/search.json?author=";
            }
            else
            {
                baseUrl = "http://openlibrary.org/search.json?title=";
            }

            connectionString = baseUrl + query;

            var result = GetApiResponse(connectionString).Result;

            BooksList booksList = JsonSerializer.Deserialize<BooksList>(result);

            foreach (var book in booksList.docs)
            {
                //var tempBook = new Book { title = book.title, author_name = book.author_name };
                var bookModel = new BookViewModel(book);
                searchLibrary.Books.Add(bookModel);
            }

            var a = 0;
        }
    }
}
