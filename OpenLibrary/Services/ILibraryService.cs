using OpenLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.Services
{
    public interface ILibraryService
    {
        Task<BooksList> GetApiResponse();
    }
}
