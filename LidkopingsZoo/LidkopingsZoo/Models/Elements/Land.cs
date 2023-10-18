namespace LidkopingsZoo.Models.Elements
{
    public abstract class Land : Habitat
    {
        //KM/H
        public abstract int Speed { get; set; }
        public Land(int Speed, string name, string description) : base(name, description)
        {
            this.Speed = Speed;
            this.Name = name;
            this.Description = description;
        }
        public void IRun()
        {
            Console.WriteLine("I run");
        }
    }
}
