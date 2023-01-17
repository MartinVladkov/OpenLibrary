using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OpenLibrary.Models
{
    public class Book : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //private string Isbn;

        //public string isbn
        //{
        //    get { return Isbn; }
        //    set { Isbn = value; OnPropertyChanged("Isbn"); }
        //}

        public string title { get; set; }

        //private string Title { get; set; }

        //public string title
        //{
        //    get { return Title; }
        //    set { Title = value; OnPropertyChanged("title"); }
        //}

        //private string AuthorName { get; set; }

        //public string author_name
        //{
        //    get { return AuthorName; }
        //    set { AuthorName = value; OnPropertyChanged("author_name"); }
        //}

        //private int pageCount { get; set; }

        //public int PageCount
        //{
        //    get { return pageCount; }
        //    set { pageCount = value; OnPropertyChanged("PageCount"); }
        //}

        //private DateTime FirstPublishYear { get; set; }

        //public DateTime first_publish_year
        //{
        //    get { return FirstPublishYear; }
        //    set { FirstPublishYear = value; OnPropertyChanged("first_publish_year"); }
        //}

        //private string bookCover { get; set; }

        //public string BookCover
        //{
        //    get { return bookCover; }
        //    set { bookCover = value; OnPropertyChanged("BookCover"); }
        //}

    }
}
