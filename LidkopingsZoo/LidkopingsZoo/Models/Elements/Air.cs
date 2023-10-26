namespace LidkopingsZoo.Models.Elements
{
    public abstract class Air : Habitat
    {
        //METERS
        public abstract int MaxAltitude { get; set; }
        public Air(string name, string description, int age, int maxAltitude) : base(name, description, age)
        {
            MaxAltitude = MaxAltitude;
            Name = name;
            Description = description;
        }
        public static object IMove()
        {
            return "I fly";
        }
        public static object ISound()
        {
            return "Swishh swishh";
        }
    }
}
