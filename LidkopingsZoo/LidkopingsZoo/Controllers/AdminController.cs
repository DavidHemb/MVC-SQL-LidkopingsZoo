using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LidkopingsZoo.Services.Admin;
using LidkopingsZoo.Services.Tours;
using System.Data;
using LidkopingsZoo.Models;
using LidkopingsZoo.Models.ViewModels;
using LidkopingsZoo.Models.Animals.LandAnimals;
using LidkopingsZoo.Models.Animals.AirAnimals;
using LidkopingsZoo.Models.Animals.WaterAnimals;

namespace LidkopingsZoo.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly AdminServices _adminServices;
        private readonly TourServices _tourServices;
        public AdminController(ILogger<AdminController> logger, AdminServices AdminServices, TourServices TourServices)
        {
            _logger = logger;
            _adminServices = AdminServices;
            _tourServices = TourServices;
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminPanel()
        {
            List<List<string>> SpeciesList = new List<List<string>>();
            List<List<string>> AnimalsList = new List<List<string>>();
            SpeciesList = await _adminServices.GetAllSpeciesNameInRow();
            AnimalsList = await _tourServices.GetAllAnimals();
            var Viewmodel = new AdminPanelViewModel()
            {
                Animals = AnimalsList,
                Species = SpeciesList,
            };
            return View(Viewmodel);
        }
        public async Task<IActionResult> AddAnimals()
        {
            List<List<string>> SpeciesList = new List<List<string>>();
            try
            {
                SpeciesList = await _adminServices.GetAllSpeciesNameInRow();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            ViewBag.Species = SpeciesList;
            return View(ViewBag);
        }
        public IActionResult EditAnimals()
        {
            return View();
        }
        public IActionResult RemoveAnimals()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAnimalMethod(string name, string desc, int age, int specialattribute, string species)
        {
            try
            {
                switch(species)
                {
                    case "Dragon":
                        Animal Dragon = new Dragon(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Dragon);
                        break;
                    case "Goose":
                        Animal Goose = new Goose(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Goose);
                        break;
                    case "Griffin":
                        Animal Griffin = new Griffin(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Griffin);
                        break;

                    case "Cow":
                        Animal Cow = new Cow(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Cow);
                        break;
                    case "Giganotosaurus":
                        Animal Giganotosaurus = new Giganotosaurus(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Giganotosaurus);
                        break;
                    case "SantaClaus":
                        Animal SantaClaus = new SantaClaus(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(SantaClaus);
                        break;

                    case "Kraken":
                        Animal Kraken = new Kraken(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Kraken);
                        break;
                    case "Orca":
                        Animal Orca = new Orca(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Orca);
                        break;
                    case "Penguin":
                        Animal Penguin = new Penguin(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Penguin);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return RedirectToAction("AdminPanel");
        }
        [HttpPost]
        public async Task<IActionResult> EditAnimalsInfo(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("EditAnimals");
            }
            try
            {
                var animal = await _adminServices.GetAnimalByIdA(id);

                if (animal == null)
                {
                    return RedirectToAction("EditAnimals");
                }
                var EditViewModel = new EditAnimalsInfoViewModel()
                {
                    ID = id,
                    EditAnimal = animal,
                };
                return View(EditViewModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } 
        }
        [HttpPost]
        public async Task<IActionResult> EditAnimalsMethod(int id, string name, string desc, int age)
        {
            try
            {
                var oldanimal = await _adminServices.GetAnimalByIdA(id);
                //GET ANIMAL SPECIES BY ID
                int specialattribute = 0;
                switch (oldanimal.SpeciesName)
                {
                    case "Dragon":
                        _adminServices.Delete(oldanimal);
                        Animal Dragon = new Dragon(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Dragon);
                        break;
                    case "Goose":
                        _adminServices.Delete(oldanimal);
                        Animal Goose = new Goose(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Goose);
                        break;
                    case "Griffin":
                        await RemoveAnimalsMethod(oldanimal.Id);
                        Animal Griffin = new Griffin(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Griffin);
                        break;
                    case "Cow":
                        _adminServices.Delete(oldanimal);
                        Animal Cow = new Cow(name, desc, age, specialattribute);
                        Cow.Id = id;
                        _adminServices.AddAnimal(Cow);
                        break;
                    case "Giganotosaurus":
                        _adminServices.Delete(oldanimal);
                        Animal Giganotosaurus = new Giganotosaurus(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Giganotosaurus);
                        break;
                    case "SantaClaus":
                        _adminServices.Delete(oldanimal);
                        Animal SantaClaus = new SantaClaus(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(SantaClaus);
                        break;
                    case "Kraken":
                        _adminServices.Delete(oldanimal);
                        Animal Kraken = new Kraken(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Kraken);
                        break;
                    case "Orca":
                        _adminServices.Delete(oldanimal);
                        Animal Orca = new Orca(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Orca);
                        break;
                    case "Penguin":
                        _adminServices.Delete(oldanimal);
                        Animal Penguin = new Penguin(name, desc, age, specialattribute);
                        _adminServices.AddAnimal(Penguin);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return RedirectToAction("AdminPanel");
        }
        public async Task<IActionResult> RemoveAnimalsMethod(int id)
        {
            try
            {
                var animal = await _adminServices.GetAnimalByIdA(id);
                var guideAnimals = await _adminServices.GetGuideAnimalIdA(animal.Id);
                _adminServices.DeleteGuideIds(guideAnimals);
                _adminServices.Delete(animal);
                return RedirectToAction("AdminPanel");
            }
            catch
            {
                var animal = await _adminServices.GetAnimalByIdA(id);
                _adminServices.Delete(animal);
                return RedirectToAction("AdminPanel");
            }
        }
    }
}
