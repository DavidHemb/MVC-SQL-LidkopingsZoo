using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using LidkopingsZoo.Models.ViewModels;
using LidkopingsZoo.Models.Visitation;
using LidkopingsZoo.Services.Users;
using Microsoft.AspNetCore.Identity;
using LidkopingsZoo.Services.Guides;
using LidkopingsZoo.Models;
using LidkopingsZoo.Services.Tours;

namespace LidkopingsZoo.Controllers
{
    public class GuideController : Controller
    {
        private readonly GuideServices _guideServices;
        private readonly TourServices _tourServices;

        public GuideController(GuideServices guideServices, TourServices tourServices)
        {
            _guideServices = guideServices;
            _tourServices = tourServices;
        }

        [Authorize(Roles = "Admin, Guide")]
        public IActionResult GuidePanel()
        {
            return View();
        }

        //public async Task<IActionResult> AvailableGuides(string SpeciesName)
        //{
        //    var AnimalIdList = await _tourServices.GetAllAnimalIds();
        //    List<List<string>> AnimalList = new List<List<string>>();
        //    try
        //    {
        //        foreach (var Animal in AnimalIdList)
        //        {

        //            AnimalList = await _tourServices.GetAllAnimals();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //    var viewModel = new GuideAnimalsVievModel()
        //    {

        //    };

        //    return View("~/views/guide/availableguides.cshtml", viewModel);
        //}

        public async Task<IActionResult> AvailableGuides(string SpeciesName)
        {
            List<Guide> guides = await _guideServices.GetGuidesByCompetence(SpeciesName);
            var animals = await _tourServices.GetAllAnimalsBySpeciesName(SpeciesName);
            var viewModel = new GuideAnimalsVievModel()
            {
                animals = animals,
                guides = guides
            };

            return View("~/views/guide/availableguides.cshtml", viewModel);
        }
    }
}
