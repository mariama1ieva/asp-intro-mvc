using Asp_intro_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro_mvc.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var datas = GetAllBooks();
            return View(datas);
        }

        private List<Book> GetAllBooks()
        {
            return new List<Book>
            {
                new Book()
                {
                    Id = 1,
                    Name= "To Kill a Mockingbird"
                },
                   new Book()
                {
                    Id = 2,
                    Name= "1984"
                },
                      new Book()
                {
                    Id = 3,
                    Name= "One Hundred Years of Solitude"
                },
                         new Book()
                {
                    Id = 4,
                    Name= "The Great Gatsby"
                }
            };
        }
    }
}
