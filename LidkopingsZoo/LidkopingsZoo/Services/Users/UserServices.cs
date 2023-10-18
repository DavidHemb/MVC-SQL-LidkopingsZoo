using LidkopingsZoo.Data;
using LidkopingsZoo.Models;
using Microsoft.AspNetCore.Identity;

namespace LidkopingsZoo.Services.Users
{
    public class UserServices
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public UserServices(ApplicationDbContext context,RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }
    }
}
