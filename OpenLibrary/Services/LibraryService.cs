using OpenLibrary.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows;
using System;
using NLog;

namespace OpenLibrary.Services
{
    public class LibraryService : ILibraryService
    {
        private static readonly HttpClient Client = new HttpClient();

        Logger log = LogManager.GetCurrentClassLogger();

        private async Task<string> GetApiResponse(string connectionString)
        {
            string response = await Client.GetStringAsync(connectionString);

            return response;
        }

        public async Task<List<Book>> SearchBook(string SearchTerm, bool SearchByTitle, bool SearchByAuthor) 
        {
            string connectionString = "";
            string baseUrl = "";

            if (SearchByAuthor == true)
            {
                baseUrl = "http://openlibrary.org/search.json?author=";
            }
            else
            {
                baseUrl = "http://openlibrary.org/search.json?title=";
            }

            connectionString = baseUrl + SearchTerm;

            var result = await GetApiResponse(connectionString);

            if (result == null)
            {
                MessageBox.Show("No result found.");
                log.Error(new Exception(), "No API response.");
            }

            BooksList booksList = JsonSerializer.Deserialize<BooksList>(result);

            if (booksList.docs.Count == 0)
            {
                MessageBox.Show("No result found.");
                log.Error(new Exception(), "No result found.");
            }

            return booksList.docs;
        }
    }
}
