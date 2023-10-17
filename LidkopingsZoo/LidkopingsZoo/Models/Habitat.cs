using System.Linq.Expressions;

namespace LidkopingsZoo.Models
{
    public abstract class Habitat : Animal
    {
        public int HabitatId { get; set; }
        public Habitat(string name, string description) : base(name, description)
        {
            this.Name = name;
            this.Description = description;
        }
        public abstract void IRun();
        public abstract void IFly();
        public abstract void ISwim();
    }
}
