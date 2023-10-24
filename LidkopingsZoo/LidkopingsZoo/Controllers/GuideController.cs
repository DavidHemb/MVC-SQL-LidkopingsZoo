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

        [Authorize(Roles = "Admin, Guide")]
        public async Task<IActionResult> BookedTours()
        {
            // Get Logged in Guide.
            var guideName = User.Identity.Name.ToString();
            
            var guideId = _guideServices.GetGuideIdByName(guideName);

            // Gets Booked Tours Of Logged In Guide.
            var tours = _tourServices.GetAllToursByGuideId(guideId);

            // Viewmodel for easier distribution of properties in View.
            var viewModel = new ToursViewModel()
            {
                visits = tours,
            };

            return View(viewModel);
        }

        public async Task<IActionResult> AvailableGuides(string SpeciesName)
        {
            List<Guide> guides = await _guideServices.GetGuidesByCompetence(SpeciesName);
            var animals = await _tourServices.GetAllAnimalsBySpeciesName(SpeciesName);
            var bookedVisits = await _guideServices.GetBookedVisits();
            var viewModel = new GuideAnimalsVievModel()
            {
                animals = animals,
                guides = guides,
                bookedVisits = bookedVisits
            };

            return View("~/views/guide/availableguides.cshtml", viewModel);
        }
    }
}
