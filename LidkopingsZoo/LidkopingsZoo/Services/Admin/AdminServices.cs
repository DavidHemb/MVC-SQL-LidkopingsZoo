using LidkopingsZoo.Data;
using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Animals.LandAnimals;
using Microsoft.EntityFrameworkCore;

namespace LidkopingsZoo.Services.Admin
{
    public class AdminServices
    {
        private readonly ApplicationDbContext _context;
        public AdminServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
        public bool AddAnimal(Animal animal)
        {
            _context.Animal.Add(animal);
            return Save();
        }
        public async Task<bool> Edit(Cow animal)
        {
            _context.Animal.Update(animal);
            return Save();
        }
        public async Task<bool> Delete(Animal animal)
        {
            _context.Animal.Remove(animal);
            return Save();
        }
        public async Task<Animal> GetAnimalByIdA(int id)
        {
            var animal = _context.Animal
                .Where(b => b != null)
                .FirstOrDefault();

            //var desc = _context.Animal
            //    .Where(b => b.Id == id)
            //    .Select(b => b.Description)
            //    .FirstOrDefault();

            //var age = _context.Animal
            //    .Where(b => b.Id == id)
            //    .Select(b => b.Age)
            //    .FirstOrDefault();
            //var species = _context.Animal
            //    .Where(b => b.Id == id)
            //    .Select(b => b.SpeciesName)
            //    .FirstOrDefault();

            //Animal animal = new Animal(name, desc, age);
            return animal;
        }
        public async Task<List<string>> GetAnimalById(int id)
        {

            var name = _context.Animal
                .Where(b => b.Id == id)
                .Select(b => b.Name)
                .FirstOrDefault();

            var desc = _context.Animal
                .Where(b => b.Id == id)
                .Select(b => b.Description)
                .FirstOrDefault();

            var age = _context.Animal
                .Where(b => b.Id == id)
                .Select(b => b.Age)
                .FirstOrDefault();
            var species = _context.Animal
                .Where(b => b.Id == id)
                .Select(b => b.SpeciesName)
                .FirstOrDefault();

            List<string> FullList = new List<string>
            {
                name,
                desc,
                age.ToString(),
                species
            };
            return FullList;
        }
        public async Task<List<List<string>>> GetAllSpeciesNameInRow()
        {
            //SpeciesName
            var SpeciesName = _context.Animal
                .Where(r => r.HabitatId == 1 || r.HabitatId == 2 || r.HabitatId == 3)
                .Select(r => r.SpeciesName)
                .Distinct()
                .ToList();

            //Summary
            List<List<string>> FullList = new List<List<string>>();

            //Finally
            FullList.Add(SpeciesName);
            return FullList;
        }
    }
}
