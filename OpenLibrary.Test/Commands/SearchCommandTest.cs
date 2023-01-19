using OpenLibrary.Commands;
using OpenLibrary.Test.Mocks;
using OpenLibrary.ViewModels;
using Xunit;

namespace OpenLibrary.Test.Commands
{
    public class SearchCommandTest
    {
        [Theory]
        [InlineData("Book Title", true, false)]
        [InlineData("Author", false, true)]
        public void SearchCommandFillsBooksCollection(string SearchTerm, bool SearchByTitle, bool SearchByAuthor)
        {
            //Arrange
            var libraryService = LibraryServiceMock.Instance;
            var searchLibrary = new SearchLibraryViewModel();

            searchLibrary.SearchTerm = SearchTerm;
            searchLibrary.SearchByTitle = SearchByTitle;
            searchLibrary.SearchByAuthor = SearchByAuthor;

            var searchCommand = new SearchCommand(searchLibrary, libraryService);

            //Act
            searchCommand.Execute(null); ;

            //Assert
            Assert.NotNull(searchLibrary.Books);
            Assert.Equal(2, searchLibrary.Books.Count);
        }
    }
}
