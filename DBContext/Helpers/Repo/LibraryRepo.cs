using System;
using System.Collections.Generic;
using System.Linq;

namespace DBContext.Helpers.Repo
{
    public class LibraryRepo
    {
        private Context.LibraryContext _context;

        public LibraryRepo()
        {
            _context = new Context.LibraryContext();
        }

        public bool AddAuthor(Models.AutherModels author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateAuthor(Models.AutherModels author)
        {
            _context.Entry(author).State = System.Data.EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

        public bool RemoveAuthor(Models.AutherModels author)
        {
            _context.Entry(author).State = System.Data.EntityState.Deleted;
            _context.SaveChanges();
            return true;
        }

        public List<Models.AutherModels> RetrieveAuthor()
        {
            List<Models.AutherModels> authors = new List<Models.AutherModels>();
            foreach (var author in _context.Authors)
            {
                authors.Add(author);
            }
            return authors;
        }


        public Models.AutherModels RetrieveAuthorById(Guid AuthorId)
        {
            return _context.Authors.Find(AuthorId);
        }

        public Models.AutherModels RetrieveAuthorByName(string name)
        {
            var author = (from authors in _context.Authors
                          where authors.AuthorName.Contains(name)
                          select authors).FirstOrDefault();
            return author;
        }

        public bool AddBooks(Models.BooksModels books)
        {
            _context.Books.Add(books);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateBooks(Models.BooksModels books)
        {
            _context.Entry(books).State = System.Data.EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

        public bool RemoveBooks(Models.BooksModels books)
        {
            _context.Entry(books).State = System.Data.EntityState.Deleted;
            _context.SaveChanges();
            return true;
        }

        public List<Models.BooksModels> RetrieveBooks()
        {
            List<Models.BooksModels> books = new List<Models.BooksModels>();
            foreach (var book in _context.Books)
            {
                books.Add(book);
            }
            return books;
        }

        public Models.BooksModels RetrieveBooksById(Guid BookId)
        {
            return _context.Books.Find(BookId);
        }

        public Models.BooksModels RetrieveBooksByName(string name)
        {
            var book = (from books in _context.Books
                        where books.BookName.Contains(name)
                        select books).FirstOrDefault();
            return book;
        }
    }
}