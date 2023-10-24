namespace LidkopingsZoo.Models.Elements
{
    public abstract class Water : Habitat
    {
        //METERS
        public abstract int DivingDepth { get; set; }
        public Water(string name, string description, int age, int divingdepth) : base(name, description, age)
        {
            this.Name = name;
            this.Description = description;
            this.DivingDepth = divingdepth;
        }
        public void ISwim()
        {
            Console.WriteLine("I swim");
        }
    }
}
