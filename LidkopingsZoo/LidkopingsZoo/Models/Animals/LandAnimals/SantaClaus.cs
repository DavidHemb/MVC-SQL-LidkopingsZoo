using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.LandAnimals
{
    public class SantaClaus : Land
    {
        public override int Speed { get; set; }
        public SantaClaus(string name, string description, int age, int speed) : base(name, description, age, speed)
        {
            this.Name = name;
            this.Description = description;
            this.Age = age;
            this.SpeciesName = "SantaClaus";
            this.HabitatId = 2;
            this.Speed = 539626424;
        }
    }
}