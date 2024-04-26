using Asp_intro_mvc.ViewModels.Book;
using Asp_intro_mvc.ViewModels.Employee;
using Asp_intro_mvc.ViewModels.Product;
using Asp_intro_mvc.ViewModels.User;


namespace Asp_intro_mvc.ViewModels
{
    public class HomeVM
    {
        public List<UserVM> Users { get; set; }
        public List<EmployeeVM> Employees { get; set; }
        public List<BookVM> Books { get; set; }
        public List<ProductVM> Products { get; set; }
    }
}
