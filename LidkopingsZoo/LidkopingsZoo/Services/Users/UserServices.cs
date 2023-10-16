using LidkopingsZoo.Data;
using LidkopingsZoo.Models;
using Microsoft.AspNetCore.Identity;

namespace LidkopingsZoo.Services.Users
{
    public class UserServices
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserServices(ApplicationDbContext context, UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
    }
}
