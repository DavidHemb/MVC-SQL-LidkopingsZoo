using System.Linq.Expressions;

namespace LidkopingsZoo.Models
{
    public abstract class Habitat : Animal
    {
        public Habitat(string name, string description) : base(name, description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
