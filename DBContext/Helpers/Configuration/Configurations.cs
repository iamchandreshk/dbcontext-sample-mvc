using System.Data.Entity.ModelConfiguration;

namespace DBContext.Helpers.Configuration
{
    public class BooksConfiguration : EntityTypeConfiguration<Models.BooksModels>
    {
        public BooksConfiguration()
        {
            Property(p => p.BookName).IsRequired().HasMaxLength(50);
            Property(p => p.AuthorId).IsRequired();
        }
    }

    public class AuthorConfiguration : EntityTypeConfiguration<Models.AutherModels>
    {
        public AuthorConfiguration()
        {
            Property(p => p.AuthorName).IsRequired().HasMaxLength(50);
        }
    }
}