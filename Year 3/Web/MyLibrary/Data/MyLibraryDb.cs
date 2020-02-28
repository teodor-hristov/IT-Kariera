using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MyLibraryDb : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=MyLibraryDb;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
