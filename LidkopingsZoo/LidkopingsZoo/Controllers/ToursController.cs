using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Elements;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LidkopingsZoo.Models.ViewModels;
using LidkopingsZoo.Services.Tours;
using LidkopingsZoo.Services.Guides;
using LidkopingsZoo.Models.Visitation;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.SqlServer.Server;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LidkopingsZoo.Controllers
{
    public class ToursController : Controller
    {
        private readonly ILogger<ToursController> _logger;
        private readonly TourServices _tourServices;
        private readonly GuideServices _guideServices;
        public ToursController(ILogger<ToursController> logger, TourServices tourServices, GuideServices guideServices)
        {
            _logger = logger;
            _tourServices = tourServices;
            _guideServices = guideServices;
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
        public async Task<IActionResult> BookTour(int guideId, string visitDay, string visitTime,string species)
        {
            var guide = await _guideServices.GetGuideById(guideId);

            var viewModel = new ToursViewModel()
            {
                Guide = guide,
                visitTime = visitTime,
                visitDate = visitDay,
                species = species
            };

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTour(int guideId, string userId, string date, string time, string species, int number)
        {
            DateTime day = DateTime.Parse(date);
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var tour = new Visit()
            {
                Guides = await _guideServices.GetGuideById(guideId),
                VisitDay = day,
                VisitTime = time,
                Species = species,
                Visitors = number,
                UserId = userId
            };

            if (!await _tourServices.CreateTour(tour))
            {
                return BadRequest();
            }
            else
            {
                return View("ThankYou");
            }
        }
    }
}
