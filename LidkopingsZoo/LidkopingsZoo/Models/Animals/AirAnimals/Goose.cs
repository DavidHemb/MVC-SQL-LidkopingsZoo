using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.AirAnimals
{
    public class Goose : Air
    {
        public override int MaxAltitude { get; set; }
        public Goose(string name, string description, int age, int MaxAltitude) : base(name, description, age, MaxAltitude)
        {
            this.Name = name;
            this.Description = description;
            this.Age = age;
            this.SpeciesName = "Goose";
            this.HabitatId = 1;
            this.MaxAltitude = 8800;
        }
    }
}
