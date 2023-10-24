using System.Linq.Expressions;

namespace LidkopingsZoo.Models
{
    public abstract class Habitat : Animal
    {
        public Habitat(string name, string description, int age) : base(name, description, age)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
