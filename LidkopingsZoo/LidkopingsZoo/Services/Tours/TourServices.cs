using LidkopingsZoo.Data;
using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Visitation;
using Microsoft.EntityFrameworkCore;

namespace LidkopingsZoo.Services.Tours
{
    public class TourServices
    {
        private readonly ApplicationDbContext _context;
        public TourServices(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task<List<int>> GetAllAnimals()
        {
            return _context.Animal
                .Select(r => r.Id)
                .ToList();
        }
        public async Task<List<int>> GetAllGuides()
        {
            return _context.Guides
                .Select(r => r.Id)
                .ToList();
        }
        public async Task<List<int>> GetAllguideAnimals()
        {
            return _context.guideAnimals
                //.Select(r => r.GuideId)
                .Select(r => r.AnimalId)
                .ToList();
        }
    }
}
