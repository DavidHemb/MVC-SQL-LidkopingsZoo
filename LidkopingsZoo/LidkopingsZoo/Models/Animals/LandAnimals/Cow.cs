using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.LandAnimals
{
    public class Cow : Land
    {
        public override int Speed { get; set; }
        public Cow(string name, string description, int age, int speed) : base(name, description, speed)
        {
            this.Name = name;
            this.Description = description;
            this.Age = age;
            this.SpeciesName = "Cow";
            this.HabitatId = 2;
            this.Speed = 27;
        }
    }
}