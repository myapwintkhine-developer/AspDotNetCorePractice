using Microsoft.AspNetCore.Mvc;

namespace WorkOut.Controllers
{
    public class CurrencyConverterController : Controller
    {
        public IActionResult CurrencyConvertorV1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CurrencyConvertorV1(string fromCurrency,decimal amount)
        {
            if(fromCurrency is null) {
                ViewBag.msg = "There is no currency chosen";
                return View();
            }
            decimal result = 0;
            switch (fromCurrency)
            {
                case "usd":result = amount * 2000.75M;break;
                case "sgd": result = amount * 2100.6M;break;
                case "tbh": result = amount * 98.22M; break;
            }
            ViewBag.Result = result;
            return View();
        }

        public IActionResult CurrencyConvertorV2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CurrencyConvertorV2(string fromCurrency, decimal amount)
        {
            if (fromCurrency is null)
            {
                ViewBag.msg = "There is no currency chosen";
                return View();
            }
            decimal result = 0;
            switch (fromCurrency)
            {
                case "usd": result = amount * 2000.75M; break;
                case "sgd": result = amount * 2100.6M; break;
                case "tbh": result = amount * 98.22M; break;
            }
            ViewBag.FromCurrency=fromCurrency;
            ViewBag.Amount = amount;
            ViewBag.Result = result;
            return View();
        }
    }
}
