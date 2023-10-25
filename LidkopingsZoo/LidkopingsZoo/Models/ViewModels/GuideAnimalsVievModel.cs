using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Visitation;

namespace LidkopingsZoo.Models.ViewModels
{
    public class GuideAnimalsVievModel
    {
        public Guide guide { get; set; }
        public Animal animal { get; set; }
        public List<Guide> guides { get; set; }
        public List<Visit> bookedVisits { get; set; }
        public List<Animal> AnimalCompetence { get; set; }
        public List<List<string>> animals { get; set; }

    }
}
