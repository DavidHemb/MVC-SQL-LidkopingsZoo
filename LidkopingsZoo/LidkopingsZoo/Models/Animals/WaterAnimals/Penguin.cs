using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.WaterAnimals
{
    public class Penguin : Water
    {
        public override int DivingDepth { get; set; }
        public Penguin(string name, string description, int age, int DivingDepth) : base(name, description, DivingDepth)
        {
            this.Name = name;
            this.Description = description;
            this.Age = age;
            this.SpeciesName = "Penguin";
            this.HabitatId = 3;
            this.DivingDepth = 300;
        }
    }
}
