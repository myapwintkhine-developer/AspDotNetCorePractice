using FirstMVCDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        
        IList<Student> students = new List<Student>();
        [HttpPost]
        public IActionResult Register(string firstName,string lastName,string DOB, string address,string Gender)
        {
            students.Add(new Student
            {
                FirstName = firstName,
                LastName = lastName,
                DOB = DateOnly.FromDateTime(Convert.ToDateTime(DOB)),
                Address = address,
                Gender = Gender

            });
            TempData["Info"] = "1 student is successfully registered";
            TempData["StudentCount"] = students.Count;
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
