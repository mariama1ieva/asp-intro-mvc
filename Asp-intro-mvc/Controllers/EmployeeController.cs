using Asp_intro_mvc.Models;
using Asp_intro_mvc.ViewModels.Employee;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro_mvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var datas = GetEmployees();
            List<EmployeeVM> employees = new List<EmployeeVM>();

            foreach (var employee in datas)
            {
                employees.Add(new EmployeeVM
                {
                    Name = employee.Name,
                    Surname = employee.Surname,
                    Age = employee.Age,
                    Salary = employee.Salary,
                });
            }

            return View(employees);
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
    }
}
