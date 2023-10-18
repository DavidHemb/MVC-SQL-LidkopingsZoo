using Microsoft.AspNetCore.Mvc;

namespace LidkopingsZoo.Controllers
{
    public class Admin : Controller
    {
        public IActionResult AdminPanel()
        {
            return View();
        }
        public IActionResult GuidePanel()
        {
            return View();
        }
    }
}
