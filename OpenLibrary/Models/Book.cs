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

        public List<string> isbn { get; set; }

        public string title { get; set; }

        public List<string> author_name { get; set; } = new List<string>();

        public int number_of_pages_median { get; set; }

        public int first_publish_year { get; set; }

        public int cover_i { get; set; } //find cover here: https://covers.openlibrary.org/b/$key/$value-$size.jpg exmpl: https://covers.openlibrary.org/b/isbn/0385472579-S.jpg
    }
}
