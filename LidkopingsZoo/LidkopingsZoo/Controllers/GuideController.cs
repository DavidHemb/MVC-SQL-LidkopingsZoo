using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LidkopingsZoo.Controllers
{
    public class GuideController : Controller
    {
        [Authorize(Roles = "Admin, Guide")]
        public IActionResult GuidePanel()
        {
            return View();
        }
    }
}
