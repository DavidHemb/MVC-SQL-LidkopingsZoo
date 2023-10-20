using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using LidkopingsZoo.Models.ViewModels;
using LidkopingsZoo.Models.Visitation;
using LidkopingsZoo.Services.Users;
using Microsoft.AspNetCore.Identity;
using LidkopingsZoo.Services.Guide;
using LidkopingsZoo.Models;

namespace LidkopingsZoo.Controllers
{
    public class GuideController : Controller
    {
        private readonly GuideServices _guideServices;

        public GuideController(GuideServices guideServices)
        {
            _guideServices = guideServices;
        }

        [Authorize(Roles = "Admin, Guide")]
        public IActionResult GuidePanel()
        {
            return View();
        }

        [Authorize(Roles = "Admin, Guide")]
        public IActionResult Animals()
        {
            var guideName = User.Identity.Name;
            var tempGuideId = _guideServices.GetGuideIdByName(guideName);

            var guideId = Convert.ToInt32(tempGuideId.Result);

            List<Animal> animals = _guideServices.GetAnimalsByCompetence(guideId);

            var viewModel = new GuideAnimalsVievModel()
            {
                animals = _guideServices.GetAnimalsByCompetence(guideId)
            };
            
            return View("~/views/guide/specifiedanimals.cshtml", viewModel);
        }
    }
}
