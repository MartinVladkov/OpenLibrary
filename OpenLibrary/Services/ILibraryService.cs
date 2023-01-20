using OpenLibrary.Models;
using OpenLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.Services
{
    public interface ILibraryService
    {
        public Task<List<Book>> SearchBook(string SearchTerm, bool SearchByTitle, bool SearchByAuthor);
    }
}
