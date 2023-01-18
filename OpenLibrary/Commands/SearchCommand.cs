using OpenLibrary.Services;
using OpenLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            libraryService.GetApiResponse(searchLibrary);
        }
    }
}
