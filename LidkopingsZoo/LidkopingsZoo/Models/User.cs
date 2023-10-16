using Microsoft.AspNetCore.Identity;

namespace LidkopingsZoo.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}
