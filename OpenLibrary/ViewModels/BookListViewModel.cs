using OpenLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.ViewModels
{
    public class BookListViewModel : ViewModelBase
    {
        private readonly Book book;

        public string Title => book.title;

        public string Author => book.author_name.FirstOrDefault();

        public BookListViewModel(Book book)
        {
                this.book = book;
        }
    }
}
