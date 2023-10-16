using Microsoft.AspNetCore.Identity;
namespace LidkopingsZoo.Models.Visitation
    
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime VisitTime { get; set; }
        public string Visitors { get; set; }
        public Guide Guides { get; set; }
        public IdentityUser User { get; set; }
    }
}
