using Microsoft.AspNetCore.Identity;

namespace LidkopingsZoo.Models
{
    public class User : IdentityUser
    {
    public User(string userName) : base(userName)
        {
            this .UserName = userName;
        }
    }
}
