using LidkopingsZoo.Models;
using Humanizer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using LidkopingsZoo.Services.UserServices;
using LidkopingsZoo.Data;
using Microsoft.EntityFrameworkCore;
namespace LidkopingsZoo.Services.UserServices
{
    public class UserServices
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<UserServices> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserServices(ApplicationDbContext context, UserManager<UserServices> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
