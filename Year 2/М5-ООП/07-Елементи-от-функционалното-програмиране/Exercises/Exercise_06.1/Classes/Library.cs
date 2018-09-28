using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise_06._1.Classes
{
    class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
        }

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
