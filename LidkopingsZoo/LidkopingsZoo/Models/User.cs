using Microsoft.AspNetCore.Identity;

namespace LidkopingsZoo.Models
{
    public class User : IdentityUser
    {
        public int ID { get; set; }
    }
}
