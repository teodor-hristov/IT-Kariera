using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise_06._1.Classes
{
    class Library
    {
        private List<Book> books;

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public void Dispose() { }
            public bool MoveNext()
               => ++this.currentIndex < this.books.Count;

            public void Reset() => this.currentIndex = -1;
            public Book Current => this.books[this.currentIndex];
            object IEnumerator.Current => this.Current;

        }

        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
        
    }
}
