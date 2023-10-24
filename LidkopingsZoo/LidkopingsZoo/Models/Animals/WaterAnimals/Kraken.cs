using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.WaterAnimals
{
    public class Kraken : Water
    {
        public override int DivingDepth { get; set; }
        public Kraken(string name, string description, int age, int DivingDepth) : base(name, description, age, DivingDepth)
        {
            this.Name = name;
            this.Description = description;
            this.Age = age;
            this.SpeciesName = "Kraken";
            this.HabitatId = 3;
            this.DivingDepth = 10500;
        }
    }
}
