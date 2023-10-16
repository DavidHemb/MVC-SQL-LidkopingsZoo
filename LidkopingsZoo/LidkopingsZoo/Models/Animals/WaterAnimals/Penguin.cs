using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.WaterAnimals
{
    public class Penguin : Water
    {
        public override int DivingDepth { get; set; }
        public Penguin(int DivingDepth, string name, string description) : base(DivingDepth, name, description)
        {
            this.DivingDepth = 300;
            this.Name = "Penguin";
            this.Description = "\"Penguin\" is a family of flightless, aquatic birds known for their distinctive black and white coloration. They are mainly found in the Southern Hemisphere, with species like the Emperor, Adélie, and King penguins inhabiting Antarctica and surrounding regions. Penguins are excellent swimmers and use their flipper-like wings to navigate underwater. They primarily feed on fish and crustaceans. These charming birds have adapted to a variety of climates and are known for their social behavior, often living in colonies. Penguins have become iconic symbols of the wildlife in the Southern Hemisphere and are a popular subject in both scientific research and popular culture.";
        }
        public override void IFly()
        {
            throw new NotImplementedException();
        }

        public override void IRun()
        {
            throw new NotImplementedException();
        }

        public override void ISwim()
        {
            Console.WriteLine("I swim");
        }
    }
}
