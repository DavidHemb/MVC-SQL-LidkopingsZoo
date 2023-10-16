namespace LidkopingsZoo.Models.Elements
{
    public abstract class Land : Habitat
    {
        public abstract int Speed { get; set; }
        public Land(int Speed, string name, string description) : base(name, description)
        {
            this.Speed = Speed;
            this.Name = name;
            this.Description = description;
        }
    }
}
