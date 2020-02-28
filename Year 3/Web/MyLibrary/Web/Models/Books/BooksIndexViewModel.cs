using System.Collections.Generic;
using Web.Models.Shared;

namespace Web.Models.Books
{
    public class BooksIndexViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<BooksViewModel> Items { get; set; }
    }
}
