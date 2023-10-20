using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Elements;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LidkopingsZoo.Models.ViewModels;
using LidkopingsZoo.Services.Tours;

namespace LidkopingsZoo.Controllers
{
    public class ToursController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TourServices _tourServices;
        public ToursController(ILogger<HomeController> logger, TourServices tourServices)
        {
            _logger = logger;
            _tourServices = tourServices;
        }
        public async Task<IActionResult> Tours()
        {
            var AnimalIdList = await _tourServices.GetAllAnimalIds();
            List<List<string>> AnimalList = new List<List<string>>();
            try
            {
                foreach (var Animal in AnimalIdList)
                {

                    AnimalList = await _tourServices.GetAllAnimals();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            var toursViewModel = new ToursViewModel
            {
                Animals = AnimalList,
            };
            return View(toursViewModel);
        }
        public IActionResult ToursAnimals()
        {
            return View();
        }
    }
}
