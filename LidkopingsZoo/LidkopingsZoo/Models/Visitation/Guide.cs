using Microsoft.AspNetCore.Identity;

namespace LidkopingsZoo.Models.Visitation
{
    public class Guide 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public GuideAnimal GuideAnimal { get; set; }
    }
}
