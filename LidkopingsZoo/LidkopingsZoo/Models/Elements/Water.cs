namespace LidkopingsZoo.Models.Elements
{
    public abstract class Water : Habitat
    {
        public abstract int DivingDepth { get; set; }
        public Water(int DivingDepth, string name, string description) : base(name, description)
        {
            this.DivingDepth = DivingDepth;
            Name = name;
            Description = description;
        }
    }
}
