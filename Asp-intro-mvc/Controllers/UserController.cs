using Asp_intro_mvc.Models;
using Asp_intro_mvc.ViewModels.User;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro_mvc.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {

            var users = GetAllUsers();
            List<UserVM> userVMs = new List<UserVM>();


            foreach (var item in users)
            {
                userVMs.Add(new UserVM
                {
                    FullName = item.FullName,
                    Age = item.Age,
                    Address = item.Address,
                    Email = item.Email
                });
            }


            return View(userVMs);
        }

        private List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User()
                { Id = 1,
                 FullName = "John Smith",
                 Address = "Canada",
                 Email ="jhon@gmail.com",
                 Age= 30

                },
                 new User()
                { Id = 2,
                 FullName = "Emily Johnson",
                 Address = "NewYork",
                 Email ="emily@gmail.com",
                 Age= 25

                },
                  new User()
                { Id = 3,
                 FullName = "Michael Lee",
                 Address = "Germany",
                 Email ="lee@gmail.com",
                 Age= 23

                },
                   new User()
                { Id = 4,
                 FullName = "David Patel",
                 Address = "Madrid",
                 Email ="david@gmail.com",
                 Age= 19

                },
            };
        }
    }
}
