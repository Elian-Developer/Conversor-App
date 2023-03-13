using Conversor_Currecy_App.Services;
using Conversor_Currecy_App.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Conversor_App.Controllers
{
    public class ConversorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ConversorViewModel c)
        {
            ViewData["resultado"] = ConversorService.ConvertirMoneda(c).ToString();
            return View();
        }
    }
}
