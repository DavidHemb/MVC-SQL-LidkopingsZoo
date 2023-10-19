using LidkopingsZoo.Models.Visitation;

namespace LidkopingsZoo.Models
{
    public class GuideAnimal
    {
        public int GuideId { get; set; }
        public int AnimalId { get; set; }

        // Nested properties

        public Guide Guide { get; set; } = null!;   
        public Animal Animal { get; set; } = null!;
    }
}
