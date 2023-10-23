using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LidkopingsZoo.Services.Admin;
using System.Data;
using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Animals.LandAnimals;
using LidkopingsZoo.Models.Animals.AirAnimals;
using LidkopingsZoo.Models.Animals.WaterAnimals;

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
        [HttpPost]
        public async Task<IActionResult> AddAnimalMethod(string name, string desc, int age, int habitat, int specialattribute, string species)
        {
            try
            {
                //Animal animal = new Animal(name, desc, age, habitat, species);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return RedirectToAction("AdminPanel");
        }
    }
}
