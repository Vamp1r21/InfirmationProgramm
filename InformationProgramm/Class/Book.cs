using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationProgramm
{
    class Book
    {
        string _nameAuthor;
        string _title;

        public Book(string nameAuthor, string title)
        {
            _nameAuthor = nameAuthor;
            _title = title;
        }

        public string GetAuthor()
        {
            return _nameAuthor;
        }

        public string GetTitle()
        {
            return _title;
        }
    }
}
