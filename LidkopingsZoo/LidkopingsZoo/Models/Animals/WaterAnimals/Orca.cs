using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.WaterAnimals
{
    public class Orca : Water
    {
        public override int DivingDepth { get; set; }
        public Orca(int DivingDepth, string name, string description) : base(DivingDepth, name, description)
        {
            this.DivingDepth = 1087;
            this.Name = "KillerWhale";
            this.Description = "\"Killer Whale\" typically refers to the orca, a marine mammal known for its distinctive black and white coloration. They are among the ocean's top predators, with powerful hunting skills and complex social structures.";
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
