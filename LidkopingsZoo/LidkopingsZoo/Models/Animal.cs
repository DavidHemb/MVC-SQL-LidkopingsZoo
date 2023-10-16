namespace LidkopingsZoo.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Animal(string name, string description)
        {
        this.Name = name;
        this.Description = description;
        }
        public void Move()
        {

        }
    }
}
