using Moq;
using OpenLibrary.Models;
using OpenLibrary.Services;
using System.Collections.Generic;

namespace OpenLibrary.Test.Mocks
{
    public static class LibraryServiceMock
    {
        public static ILibraryService Instance
        {
            get
            {
                var libraryServiceMock = new Mock<ILibraryService>();

                //SearchBook()
                libraryServiceMock
                    .Setup(a => a.SearchBook("Book Title", true, false))
                    .Returns(new List<Book>
                    {
                        new Book
                        {
                            isbn = {"isbn1", "isbn2"},
                            title = "Title 1",
                            author_name = {"Author 1.1", "Author 1.2" },
                            number_of_pages_median = 120,
                            first_publish_year = 1990,
                            cover_i = 111222333

                        },
                        new Book
                        {
                            isbn = {"isbn3", "isbn4"},
                            title = "Title 2",
                            author_name = {"Author 2.1", "Author 2.2" },
                            number_of_pages_median = 420,
                            first_publish_year = 1950,
                            cover_i = 444555666

                        }
                    });

                libraryServiceMock
                .Setup(a => a.SearchBook("Author", false, true))
                .Returns(new List<Book>
                {
                        new Book
                        {
                            isbn = {"isbn1", "isbn2"},
                            title = "Title 1",
                            author_name = {"Author 1.1", "Author 1.2" },
                            number_of_pages_median = 120,
                            first_publish_year = 1990,
                            cover_i = 111222333

                        },
                        new Book
                        {
                            isbn = {"isbn3", "isbn4"},
                            title = "Title 2",
                            author_name = {"Author 2.1", "Author 2.2" },
                            number_of_pages_median = 420,
                            first_publish_year = 1950,
                            cover_i = 444555666

                        }
                });

                return libraryServiceMock.Object;
            }
        }
    }
}
