using OpenLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenLibrary.Services
{
    public class LibraryService : ILibraryService
    {
        public async Task<string> GetApiResponse()
        {
            var connectionString = "http://openlibrary.org/search.json?title=the+lord+of+the+rings&page=1";
            var client = new HttpClient();
           
            string response = await client.GetStringAsync(connectionString);

            var b = 0;

            //Console.WriteLine(response);
            //var doc = JsonDocument.Parse(response);
            //string root = doc.RootElement.GetProperty("docs").ToString();
            //Book books = JsonConvert.DeserializeObject<Book>(root);
            //BooksList books = JsonConvert.DeserializeObject<BooksList>(response);
            BooksList books = JsonSerializer.Deserialize<BooksList>(response);

            var a = 0;
            return response;
        }
    }
}
