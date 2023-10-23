using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LidkopingsZoo.Services.Admin;
using System.Data;

namespace LidkopingsZoo.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly AdminServices _adminServices;
        public AdminController(ILogger<AdminController> logger, AdminServices AdminServices)
        {
            _logger = logger;
            _adminServices = AdminServices;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AdminPanel()
        {
            return View();
        }
        public async Task<IActionResult> AddAnimalsAsync()
        {
            List<List<string>> SpeciesList = new List<List<string>>();
            try
            {
                SpeciesList = await _adminServices.GetAllSpeciesNameInRow();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            ViewBag.Species = SpeciesList;
            return View(ViewBag);
        }
        [HttpGet]
        public async Task<IActionResult> AddAnimalMethod()
        {
            List<List<string>> SpeciesList = new List<List<string>>();
            try
            {
                SpeciesList = await _adminServices.GetAllSpeciesNameInRow();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return View(ViewBag);
        }
    }
}
