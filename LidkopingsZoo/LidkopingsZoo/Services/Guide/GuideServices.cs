using LidkopingsZoo.Data;
using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Visitation;
using LidkopingsZoo.Models.Animals.AirAnimals;
using LidkopingsZoo.Models.Animals.LandAnimals;
using LidkopingsZoo.Models.Animals.WaterAnimals;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace LidkopingsZoo.Services.Guides
{
    public class GuideServices
    {
        private readonly ApplicationDbContext _context;

        public GuideServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Animal> GetAnimalsByCompetence(int guideID)
        {
            return _context.guideAnimals
       .Where(g => g.GuideId == guideID)
       .Include(a => a.Animal) // Här använder vi Include för att hämta hela Animal-entiteten.
       .Select(a => a.Animal)
       .ToList();
        }

        public int GetGuideIdByName(string name)
        {
            return _context.Guides
                    .Where(g => g.Email == name)
                    .Select(a => a.Id)
                    .SingleOrDefault(); // eller SingleOrDefault() om du förväntar dig endast en träff

        }

        public async Task<Guide> GetGuideById(int guideId)
        {
            return _context.Guides
                .Where(g => g.Id == guideId)
                .FirstOrDefault();
        }
        public async Task<List<Guide>> GetGuidesByCompetence(string speciesName)
        {
            return _context.guideAnimals
                .Where(ga => ga.Animal.SpeciesName == speciesName)
                .Select(ga => ga.Guide)
                .Distinct()
                .ToList();
        }
        public async Task<List<Visit>> GetBookedVisits()
        {
            return _context.Visits.ToList();
        }
    }
}
