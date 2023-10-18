using Microsoft.AspNetCore.Identity;
namespace LidkopingsZoo.Models.Visitation
    
{
    public class Visit
    {
        public int Id { get; set; }
        public string VisitTime { get; set; }
        public Guide Guides { get; set; }
        public ICollection<IdentityUser> User { get; set; }
        public int Visitors { get; set; }
    }
}
