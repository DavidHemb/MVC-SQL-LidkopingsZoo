using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.LandAnimals
{
    public class Giganotosaurus : Land
    {
        public override int Speed { get; set; }
        public Giganotosaurus(string name, string description, int age, int speed) : base(name, description, age, speed)
        {
            this.Name = name;
            this.Description = description;
            this.Age = age;
            this.SpeciesName = "Giganotosaurus";
            this.HabitatId = 2;
            this.Speed = 50;
        }
    }
}
