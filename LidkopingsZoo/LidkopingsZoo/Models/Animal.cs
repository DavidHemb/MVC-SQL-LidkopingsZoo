namespace LidkopingsZoo.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public int HabitatId { get; set; }
        public string SpeciesName { get; set; }
        public Animal(string name, string description, int age, int habitatid, string speciesname)
        {
        this.Name = name;
        this.Description = description;
        this.Age = age;
        this.HabitatId = habitatid;
        this.SpeciesName = speciesname;
        }
        public void Move()
        {

        }
    }
}
