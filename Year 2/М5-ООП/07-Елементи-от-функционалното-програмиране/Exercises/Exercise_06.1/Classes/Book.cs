using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_06._1
{
    class Book : IBook
    {
        private string title;
        private int year;
        private IReadOnlyList<string> authors;

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; set; }
        
    }
}
