using LidkopingsZoo.Data;
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
