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


        public async Task<IActionResult> GuideTours(int guideId)
        {

        }
    }
}
