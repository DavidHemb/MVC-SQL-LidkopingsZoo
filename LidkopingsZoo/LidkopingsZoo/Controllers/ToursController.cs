using Microsoft.AspNetCore.Mvc;

namespace LidkopingsZoo.Controllers
{
    public class ToursController : Controller
    {
        public IActionResult Tours()
        {
            return View();
        }
        public IActionResult ToursAnimals()
        {
            return View();
        }
    }
}
