using LidkopingsZoo.Data;
using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Elements;
using LidkopingsZoo.Models.Visitation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LidkopingsZoo.Services.Tours
{
    public class TourServices
    {
        private readonly ApplicationDbContext _context;
        public TourServices(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task<List<int>> GetAllAnimalIds()
        {
            return _context.Animal
                .Select(r => r.Id)
                .ToList();
        }
        public async Task<List<List<string>>> GetAllAnimals()
        {
            //Name
            var AirListName = _context.Animal
                .Where(r => r.HabitatId == 1)
                .Select(r => r.Name)
                .ToList();
            var LandListName = _context.Animal
                .Where(r => r.HabitatId == 2)
                .Select(r => r.Name)
                .ToList();
            var WaterListName = _context.Animal
                .Where(r => r.HabitatId == 3)
                .Select(r => r.Name)
                .ToList();
            //Desc
            var AirListDesc = _context.Animal
                .Where(r => r.HabitatId == 1)
                .Select(r => r.Description)
                .ToList();
            var LandListDesc = _context.Animal
                .Where(r => r.HabitatId == 2)
                .Select(r => r.Description)
                .ToList();
            var WaterListDesc = _context.Animal
                .Where(r => r.HabitatId == 3)
                .Select(r => r.Description)
                .ToList();
            //Age
            var AirListAge = _context.Animal
                .Where(r => r.HabitatId == 1)
                .Select(r => r.Age)
                .ToList();
            var LandListAge = _context.Animal
                .Where(r => r.HabitatId == 2)
                .Select(r => r.Age)
                .ToList();
            var WaterListAge = _context.Animal
                .Where(r => r.HabitatId == 3)
                .Select(r => r.Age)
                .ToList();

            //Summary
            List<List<string>> FullList = new List<List<string>>();
            List<string> AirList = new List<string>();
            List<string> WaterList = new List<string>();
            List<string> LandList = new List<string>();

            List<string> Name = new List<string>();
            List<string> Desc = new List<string>();
            List<string> Age = new List<string>();
            List<string> Habitat = new List<string>();

            //Air
            int i = 0;
            foreach (var Names in AirListName)
            {
                AirList.Add(AirListName[i]);

                AirList.Add(AirListDesc[i]);

                AirList.Add(AirListAge[i].ToString());

                AirList.Add("1");
                i++;
            }
            //Land
            i = 0;
            foreach (var Names in LandListName)
            {
                LandList.Add(LandListName[i]);

                LandList.Add(LandListDesc[i]);

                LandList.Add(LandListAge[i].ToString());

                LandList.Add("1");
                i++;
            }
            //Water
            i = 0;
            foreach (var Names in WaterListName)
            {
                WaterList.Add(WaterListName[i]);

                WaterList.Add(WaterListDesc[i]);

                WaterList.Add(WaterListAge[i].ToString());

                WaterList.Add("1");
                i++;
            }
            //Finally

            FullList.Add(AirList);
            FullList.Add(LandList);
            FullList.Add(WaterList);
            return FullList;
        }
        public async Task<List<int>> GetAllGuideIds()
        {
            return _context.Guides
                .Select(r => r.Id)
                .ToList();
        }
        public async Task<List<int>> GetAllguideAnimalIds()
        {
            return _context.guideAnimals
                //.Select(r => r.GuideId)
                .Select(r => r.AnimalId)
                .ToList();
        }
    }
}
