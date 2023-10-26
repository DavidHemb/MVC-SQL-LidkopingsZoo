namespace LidkopingsZoo.Models.Elements
{
    public abstract class Land : Habitat
    {
        //KM/H
        public abstract int Speed { get; set; }
        public Land(string name, string description, int age, int speed) : base(name, description, age)
        {
            this.Name = name;
            this.Description = description;
            this.Speed = speed;
        }
        public static object IMove()
        {
            return "I run";
        }
        public static object ISound()
        {
            return "Rarrr";
        }
    }
}
