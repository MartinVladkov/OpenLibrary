using OpenLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.ViewModels
{
    public class BookViewModel : ViewModelBase
    {
        private readonly Book book;

        public string Title => book.title;

        public string? Author => book.author_name?.FirstOrDefault();

        public string Isbn => book.isbn?.FirstOrDefault();

        public int NumberOfPages => book.number_of_pages_median;

        public int PublishYear => book.first_publish_year;

        public string Cover => "https://covers.openlibrary.org/b/id/" + book.cover_i.ToString() + "-M.jpg";

        public BookViewModel(Book book)
        {
                this.book = book;
        }
    }
}
