using Microsoft.AspNetCore.Identity;
namespace LidkopingsZoo.Models.Visitation
    
{
    public class Visit
    {
        public int Id { get; set; }
        public string VisitTime { get; set; }
        public DateTime VisitDay { get; set; }
        public Guide Guides { get; set; }
        //public IdentityUser User { get; set; }
        public string UserId { get; set; }
        public int Visitors { get; set; }
        public string Species { get; set; }
    }
}
