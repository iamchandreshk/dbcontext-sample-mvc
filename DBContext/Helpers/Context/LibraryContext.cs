using System.Data.Entity;

namespace DBContext.Helpers.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("ConnectionContext")
        {
        }

        public DbSet<Models.AutherModels> Authors { get; set; }
        public DbSet<Models.BooksModels> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Configuration.BooksConfiguration());
            modelBuilder.Configurations.Add(new Configuration.AuthorConfiguration());
        }
    }
}