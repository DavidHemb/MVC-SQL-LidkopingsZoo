namespace LidkopingsZoo.Models.Elements
{
    public abstract class Water : Habitat
    {
        //METERS
        public abstract int DivingDepth { get; set; }
        public Water(int DivingDepth, string name, string description) : base(name, description)
        {
            this.DivingDepth = DivingDepth;
            Name = name;
            Description = description;
        }
        public void ISwim()
        {
            Console.WriteLine("I swim");
        }
    }
}
