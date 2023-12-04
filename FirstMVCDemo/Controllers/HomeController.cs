using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace FirstMVCDemo.Controllers
{
    public class HomeController : Controller
    {

        public string SayHello()
        {
            return "Hello, nice to see you!";
        }

        public string GreetingMessage()
        {
            return "I am fine to meet with you.";
        }

        //TellName?name=Su Su
        public string TellName(string name)
        {
            return "Hello "+name+ " are you happy today?";
        }

        public ViewResult Index() 
        {
            string message = string.Empty;
            int hours = DateTime.Now.Hour;
            message = hours < 12 ? "Good Morning" : "Good Afternoon";
            ViewBag.Info=message;
            return View();
        }
    }
}
