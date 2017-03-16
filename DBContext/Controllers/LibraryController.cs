using System.Linq;
using System.Web.Mvc;
using System;

namespace DBContext.Controllers
{
    public class LibraryController : Controller
    {
        private Helpers.Repo.LibraryRepo library_repo;

        public LibraryController()
        {
            library_repo = new Helpers.Repo.LibraryRepo();
        }

        //[Route("author_add")]
        public ActionResult AddAuthor()
        {
            Models.AutherModels author = new Models.AutherModels
            {
                AuthorId = Guid.NewGuid(),
                AuthorName = "Vyasa",
                Added = System.DateTime.UtcNow
            };
            library_repo.AddAuthor(author);
            return View();
        }

        //[Route("book_add")]
        public ActionResult AddBooks()
        {
            Models.BooksModels book = new Models.BooksModels
            {
                AuthorId = library_repo.RetrieveAuthor().FirstOrDefault().AuthorId,
                Added = System.DateTime.UtcNow,
                BookId = Guid.NewGuid(),
                BookName = "Mahabharath"
            };
            library_repo.AddBooks(book);
            return View();
        }

        //[Route("author_list")]
        public ActionResult RetriveAuthor()
        {
            var data = library_repo.RetrieveAuthor();
            return View();
        }

        //[Route("book_list")]
        public ActionResult RetrieveBooks()
        {
            var data = library_repo.RetrieveBooksByName("Swaminarayan");
            return View();
        }

    }
}
