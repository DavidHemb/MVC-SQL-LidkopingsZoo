using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Elements;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LidkopingsZoo.Models.ViewModels;
using LidkopingsZoo.Services.Tours;

namespace LidkopingsZoo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TourServices _tourServices;
        public HomeController(ILogger<HomeController> logger, TourServices tourServices)
        {
            _logger = logger;
            _tourServices = tourServices;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public async Task<IActionResult> Profile()
        {
            var AnimalIdList = await _tourServices.GetAllAnimalIds();
            var GuideIdList = await _tourServices.GetAllGuideIds();
            var GuideAnimalIdList = await _tourServices.GetAllguideAnimalIds();
            List<List<string>> AnimalList = new List<List<string>>();
            try
            {
                foreach (var Animal in AnimalIdList)
                {

                    AnimalList = await _tourServices.GetAllAnimals();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            var homeViewModel = new HomeViewModel
            {
                AnimalsIds = AnimalIdList,
                GuidesIds = GuideIdList,
                GuideAnimalsIds = GuideAnimalIdList,

               //Animals = AnimalList,
            };
            return View(homeViewModel);
        }
        public IActionResult RecruitmentPage()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}