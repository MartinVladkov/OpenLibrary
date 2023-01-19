using OpenLibrary.Models;
using OpenLibrary.Services;
using System.Collections.Generic;
using Xunit;

namespace OpenLibrary.Test.Serivces
{
    public class LibraryServiceTest
    {
        [Theory]
        [InlineData("Title", true, false)]
        [InlineData("Author", false, true)]
        public void SearchBookShouldReturnListOfBooks(string SearchTerm, bool SearchByTitle, bool SearchByAuthor)
        {
            //Arrange
            var libraryService = new LibraryService();

            //Act
            var result = libraryService.SearchBook(SearchTerm, SearchByTitle, SearchByAuthor);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<Book>>(result);
            Assert.Equal(100, result.Count);
        }
    }
}