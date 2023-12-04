using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCDemo.Controllers
{
    //[Authorize]
    public class AboutUsController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AboutUsController(IWebHostEnvironment webHostEnvironment)  //ctrl+. =>assign field
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalculateSum(int n1,int n2)
        {
            int result = n1 + n2;
            ViewBag.sum=result;
            return View();
        }

        public FileResult SimpleDownload()
        {
            string fileName = "pexels-rachel-xiao-772429.jpg";
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "DownloadFiles//" + fileName);
            byte[] fileInBytes=System.IO.File.ReadAllBytes(filePath);
            return File(fileInBytes, "text/jpg", fileName);
        }

        [HttpGet]
        public IActionResult TellYourFullName() => View();

        [HttpPost]
        public IActionResult TellYourFullName(string firstName,string lastName)
        {
            string fullName=$"Hello, {firstName} {lastName}, Welcome to our system";
            ViewBag.FullName=fullName;
            return View();
        }

        [HttpGet]
        public IActionResult TellMeFullName(string firstName, string lastName)
        {
            string fullName = $"Hello, {firstName} {lastName}, Welcome to our system";
            ViewBag.FullName = fullName;
            return View("me");
        }

        [ActionName("me")]
        public IActionResult DoMe()
        {
            return View();
        }

        [NonAction]
        public ViewResult RandomNumber()
        {
            Random rdm=new Random();
            string result=rdm.Next(0,100).ToString();
            ViewBag.RandomNo=result;
            return View();
        }




    }
}
