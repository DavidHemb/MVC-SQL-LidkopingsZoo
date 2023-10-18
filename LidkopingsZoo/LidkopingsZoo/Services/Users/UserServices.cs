using LidkopingsZoo.Data;
using LidkopingsZoo.Models;
using Microsoft.AspNetCore.Identity;

namespace LidkopingsZoo.Services.Users
{
    public class UserServices
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserServices(ApplicationDbContext context,RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }
    }
}
