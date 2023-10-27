using LidkopingsZoo.Data;
using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Animals.LandAnimals;
using LidkopingsZoo.Models.Animals.WaterAnimals;
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
        public async Task<bool> Edit(Animal animal)
        {
            _context.Animal.Update(animal);
            return Save();
        }
        public bool Delete(Animal animal)
        {
            _context.Animal.Remove(animal);
            return Save();
        }
        public bool DeleteGuideIds(GuideAnimal guideAnimal)
        {
            _context.guideAnimals.Remove(guideAnimal);
            return Save();
        }
        public async Task<Animal> GetAnimalByIdA(int id)
        {
            var animal = _context.Animal
                .Where(b => b.Id == id)
                .FirstOrDefault();

            return animal;
        }
        public async Task<GuideAnimal> GetGuideAnimalIdA(int id)
        {
            var guideAnimal = _context.guideAnimals
                .Where(a => a.AnimalId == id)
                .FirstOrDefault();
            return guideAnimal;
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
