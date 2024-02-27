using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationProgramm
{
    class Library : IInformation
    {
        List<Book> books = new List<Book>();

        public Library()
        {
            var file = File.ReadAllLines("../../Folder/library.txt");
            string[] decemitional = { " ", "  ", "\t" };
            foreach(string fileElement in file)
            {
                string[] masElem = fileElement.Split(decemitional, StringSplitOptions.RemoveEmptyEntries);
                books.Add(new Book(masElem[0], masElem[1]));
            }
        }

        public void PrintInformation(ListBox informationBox)
        {
            informationBox.Items.Clear();
            List<string> authors = GetAuthors();
            foreach(string author in authors)
            {
                informationBox.Items.Add(author);
            }
        }

        List<string> GetAuthors()
        {
            List<string> authors = new List<string>();
            foreach(Book book in books)
            {
                string element = book.GetAuthor();
                if(!authors.Contains(element))
                {
                    authors.Add(element);
                }
            }
            return authors;
        }

        public void PrintMoreInformation(ListBox informationBox, string nameElement)
        {
            informationBox.Items.Clear();
            List<string> titles = GetBooks(nameElement);
            foreach (string title in titles)
            {
                informationBox.Items.Add(title);
            }
        }

        List<string> GetBooks(string authorName)
        {
            List<string> title = new List<string>();
            foreach (Book book in books)
            {
                if (book.GetAuthor() == authorName)
                {
                    title.Add(book.GetTitle());
                }
            }
            return title;
        }
    }
}
