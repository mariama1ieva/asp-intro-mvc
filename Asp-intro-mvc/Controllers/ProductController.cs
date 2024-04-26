using Asp_intro_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro_mvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var datas = GetAllProducts();
            return View(datas);
        }
        private List<Product> GetAllProducts()
        {
            return new List<Product>()
            {
                new Product {
                    Id = 1,
                    Name= "Phone",
                    Count = 10,
                    Price = 1500,
                    Description = "A mobile phone (or cellphone[a]) is a portable telephone that can make and receive calls over a radio frequency link while the user is moving within a telephone service area, as opposed to a fixed-location phone (landline phone). "
                },
                   new Product {
                    Id = 2,
                    Name= "TV",
                    Count = 12,
                    Price = 2000,
                    Description = "A mobile phone (or cellphone[a]) is a portable telephone that can make and receive calls over a radio frequency link while the user is moving within a telephone service area, as opposed to a fixed-location phone (landline phone). "
                },
                      new Product {
                    Id = 3,
                    Name= "Computer",
                    Count = 30,
                    Price = 3000,
                    Description = "A mobile phone (or cellphone[a]) is a portable telephone that can make and receive calls over a radio frequency link while the user is moving within a telephone service area, as opposed to a fixed-location phone (landline phone). "
                },
                         new Product {
                    Id = 4,
                    Name= "Tablet",
                    Count = 14,
                    Price = 100,
                    Description = "A mobile phone (or cellphone[a]) is a portable telephone that can make and receive calls over a radio frequency link while the user is moving within a telephone service area, as opposed to a fixed-location phone (landline phone). "
                },
            };
        }
    }
}
