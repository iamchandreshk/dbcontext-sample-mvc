using System;
using System.ComponentModel.DataAnnotations;

namespace DBContext.Models
{
    public class BooksModels
    {
        public BooksModels()
        {
            Added = DateTime.UtcNow;
        }
        [Key]
        public Guid BookId { get; set; }
        public string BookName { get; set; }
        public DateTime Added { get; set; }
        public Guid AuthorId { get; set; }
    }

    //public class BooksWithAuthorName: BooksModels
    //{
    //    public string AuthorName { get; set; }
    //}

    public class AutherModels
    {
        public AutherModels()
        {
            Added = DateTime.UtcNow;
        }
        [Key]
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
        public DateTime Added { get; set; }
    }
}