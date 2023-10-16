namespace LidkopingsZoo.Models.Elements
{
    public abstract class Air : Habitat
    {
        public abstract int MaxAltitude { get; set; }
        public Air(string name, string description) : base(name, description)
        {
            MaxAltitude = MaxAltitude;
            Name = name;
            Description = description;
        }
    }
}
