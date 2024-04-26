using Asp_intro_mvc.Models;
using Asp_intro_mvc.ViewModels;
using Asp_intro_mvc.ViewModels.Book;
using Asp_intro_mvc.ViewModels.Employee;
using Asp_intro_mvc.ViewModels.Product;
using Asp_intro_mvc.ViewModels.User;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var datas = GetAllUsers();
            var emps = GetEmployees();
            var books = GetAllBooks();
            var products = GetAllProducts();


            List<ProductVM> productVMs = new();
            List<UserVM> users = new();
            List<EmployeeVM> employees = new();
            List<BookVM> bookss = new();

            foreach (var item in products)
            {
                productVMs.Add(new ProductVM
                {
                    Name = item.Name,
                    Description = item.Description,
                    Count = item.Count,
                    Price = item.Price,
                });
            }
            foreach (var item in datas)
            {
                users.Add(new UserVM
                {
                    FullName = item.FullName,
                    Age = item.Age,
                    Email = item.Email,
                    Address = item.Address,
                });
            }
            foreach (var item in emps)
            {
                employees.Add(new EmployeeVM
                {
                    Name = item.Name,
                    Surname = item.Surname,
                    Age = item.Age,
                    Salary = item.Salary,

                });
            }
            foreach (var item in books)
            {
                bookss.Add(new BookVM
                {
                    Name = item.Name,
                });
            }


            HomeVM model = new()
            {
                Users = users,
                Employees = employees,
                Books = bookss,
                Products = productVMs

            };

            return View(model);
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
        private List<Book> GetAllBooks()
        {
            return new List<Book>()
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
        private List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee()
                {
                    Id = 1,
                    Name = "John",
                    Surname="Smith",
                    Age=44,
                    Salary=2000
                },
                  new Employee()
                {
                    Id = 2,
                    Name = "Emily",
                    Surname="JHonson",
                    Age=24,
                    Salary=1000
                },
                    new Employee()
                {
                    Id = 3,
                    Name = "Michael",
                    Surname="Lee",
                    Age=19,
                    Salary=400
                },
                      new Employee()
                {
                    Id = 4,
                    Name = "David",
                    Surname="Patel",
                    Age=34,
                    Salary=2400
                },
            };
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
