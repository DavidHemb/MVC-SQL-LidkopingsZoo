using LidkopingsZoo.Data;
using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Elements;
using LidkopingsZoo.Models.Visitation;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;

namespace LidkopingsZoo.Services.Tours
{
    public class TourServices
    {
        private readonly ApplicationDbContext _context;
        public TourServices(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<bool> CreateTour(Visit tour)
        {
            _context.Visits.Add(tour);
            return Save();
        }
        public async Task<bool> DeleteTour(Visit tour)
        {
            _context.Visits.Remove(tour);
            return Save();
        }
        public List<Visit> GetAllToursByGuideId(int guideId)
        {
            return _context.Visits
                .Where(g => g.Guides.Id == guideId).ToList();
        }
        public Visit GetTourById(int tourId) 
        {
            return _context.Visits.Where(v => v.Id == tourId).SingleOrDefault();
        }
        public async Task<List<int>> GetAllAnimalIds()
        {
            return _context.Animal
                .Select(r => r.Id)
                .ToList();
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
            //SpeciesName
            var AirListSpecies = _context.Animal
                .Where(r => r.HabitatId == 1)
                .Select(r => r.SpeciesName)
                .ToList();
            var LandListSpecies = _context.Animal
                .Where(r => r.HabitatId == 2)
                .Select(r => r.SpeciesName)
                .ToList();
            var WaterListSpecies = _context.Animal
                .Where(r => r.HabitatId == 3)
                .Select(r => r.SpeciesName)
                .ToList();

            //Summary
            List<List<string>> FullList = new List<List<string>>();
            List<string> AirList = new List<string>();
            List<string> WaterList = new List<string>();
            List<string> LandList = new List<string>();

            //Air
            int i = 0;
            foreach (var Names in AirListName)
            {
                AirList.Add(AirListName[i]);

                AirList.Add(AirListDesc[i]);

                AirList.Add(AirListAge[i].ToString());

                AirList.Add("1");

                AirList.Add(AirListSpecies[i]);
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

                LandList.Add(LandListSpecies[i]);
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

                WaterList.Add(WaterListSpecies[i]);
                i++;
            }
            //Finally
            FullList.Add(AirList);
            FullList.Add(LandList);
            FullList.Add(WaterList);
            return FullList;
        }
        public async Task<List<List<string>>> GetAllSpeciesName()
        {
            //SpeciesName
            var AirSpeciesName = _context.Animal
                .Where(r => r.HabitatId == 1)
                .Select(r => r.SpeciesName)
                .Distinct()
                .ToList();
            var LandSpeciesName = _context.Animal
                .Where(r => r.HabitatId == 2)
                .Select(r => r.SpeciesName)
                .Distinct()
                .ToList();
            var WaterSpeciesName = _context.Animal
                .Where(r => r.HabitatId == 3)
                .Select(r => r.SpeciesName)
                .Distinct()
                .ToList();

            //Summary
            List<List<string>> FullList = new List<List<string>>();
            List<string> AirList = new List<string>();
            List<string> WaterList = new List<string>();
            List<string> LandList = new List<string>();

            //Air
            int i = 0;
            foreach (var Names in AirSpeciesName)
            {
                AirList.Add(AirSpeciesName[i]);

                i++;
            }
            //Land
            i = 0;
            foreach (var Names in LandSpeciesName)
            {
                LandList.Add(LandSpeciesName[i]);

                i++;
            }
            //Water
            i = 0;
            foreach (var Names in WaterSpeciesName)
            {
                WaterList.Add(WaterSpeciesName[i]);

                i++;
            }

            //Finally
            FullList.Add(AirList);
            FullList.Add(LandList);
            FullList.Add(WaterList);
            return FullList;
        }
        public async Task<List<List<string>>> GetAllAnimalsBySpeciesName(string SpeciesName)
        {
            //Name
            var ListName = _context.Animal
                .Where(r => r.SpeciesName == SpeciesName)
                .Select(r => r.Name)
                .ToList();
            //Desc
            var ListDesc = _context.Animal
                .Where(r => r.SpeciesName == SpeciesName)
                .Select(r => r.Description)
                .ToList();
            //Age
            var ListAge = _context.Animal
                .Where(r => r.SpeciesName == SpeciesName)
                .Select(r => r.Age)
                .ToList();
            //SpeciesName
            var ListHabitatId = _context.Animal
                .Where(r => r.SpeciesName == SpeciesName)
                .Select(r => r.HabitatId)
                .ToList();

            //Summary
            List<List<string>> FullList = new List<List<string>>();
            List<string> AnimalList = new List<string>();

            int i = 0;
            foreach (var Names in ListName)
            {
                AnimalList.Add(ListName[i]);
                AnimalList.Add(ListDesc[i]);
                AnimalList.Add(ListAge[i].ToString());
                AnimalList.Add(SpeciesName);
                AnimalList.Add(ListHabitatId[i].ToString());
                
                i++;
            }
            //Finally
            FullList.Add(AnimalList);
            return FullList;
        }
        public async Task<List<Animal>> GetAllAnimalss()
        {
            return await _context.Animal
                .ToListAsync();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
