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
        private readonly ILogger<ToursController> _logger;
        private readonly TourServices _tourServices;
        public ToursController(ILogger<ToursController> logger, TourServices tourServices)
        {
            _logger = logger;
            _tourServices = tourServices;
        }
        public async Task<IActionResult> Tours()
        {
            List<List<string>> AnimalList = new List<List<string>>();
            try
            {
                AnimalList = await _tourServices.GetAllSpeciesName();
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
        [HttpPost]
        [AcceptVerbs("GET", "POST")]
        public async Task<IActionResult> ToursAnimals(string SpeciesName)
        {
            var AnimalIdList = await _tourServices.GetAllAnimalIds();
            List<List<string>> AnimalList = new List<List<string>>();
            try
            {
                foreach (var Animal in AnimalIdList)
                {

                    AnimalList = await _tourServices.GetAllAnimalsBySpeciesName(SpeciesName);
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
        public async Task<IActionResult> ToursAllAnimals()
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
        public async Task<IActionResult> CreateTour(int guideId, string visitDay, string visitTime)
        {
            return View();
        }
    }
}
