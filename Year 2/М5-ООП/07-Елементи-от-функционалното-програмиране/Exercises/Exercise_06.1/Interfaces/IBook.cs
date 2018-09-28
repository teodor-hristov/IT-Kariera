using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_06._1
{
    interface IBook
    {
        string Title { get; set; }
        int Year { get; set; }
        IReadOnlyList<string> Authors { get; set; }
    }
}
