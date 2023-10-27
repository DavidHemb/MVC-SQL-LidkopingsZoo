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
                .Include(a => a.Animal)
                .Select(a => a.Animal)
                .GroupBy(a => a.SpeciesName)
                .Select(group => group.First())
                .ToList();
        }

        public int GetGuideIdByName(string name)
        {
            return _context.Guides
                    .Where(g => g.Email == name)
                    .Select(g => g.Id)
                    .FirstOrDefault();

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
