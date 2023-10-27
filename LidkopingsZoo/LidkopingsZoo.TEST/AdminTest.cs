using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Elements;
using LidkopingsZoo.Models.Visitation;
using LidkopingsZoo.Models.Animals.AirAnimals;
using LidkopingsZoo.Models.Animals.LandAnimals;
using LidkopingsZoo.Models.Animals.WaterAnimals;
using LidkopingsZoo.Services.Admin;
using LidkopingsZoo.Services.Tours;
using LidkopingsZoo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LidkopingsZoo.TEST
{
    [TestClass]
    public class AdminTest
    {
        private ApplicationDbContext dbContext;
        private Animal newAnimal;

        [TestInitialize]
        public void Initialize()
        {
            dbContext = GetInMemoryDbContext();
        }
        private ApplicationDbContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "LidkopingsZoo")
                .Options;
            return new ApplicationDbContext(options);
        }
        //Animals
        //--------------------------------------------------------------------------------------------------
        //ADD
        //--------------------------------------------------------------------------------------------------
        //AIR
        [TestMethod]
        public async Task GooseCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Goose("Test", "Test", 10, 0)
            {
                Id = 1,
                Name = "Test",
                Description = "Test",
                Age = 10,
                MaxAltitude = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(1, dbContext.Animal.Count(), "Animal added");
        }
        [TestMethod]
        public async Task DragonCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Dragon("Test", "Test", 10, 0)
            {
                Id = 2,
                Name = "Test",
                Description = "Test",
                Age = 10,
                MaxAltitude = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(1, dbContext.Animal.Count(), "Animal added");
        }
        [TestMethod]
        public async Task GriffinCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Griffin("Test", "Test", 10, 0)
            {
                Id = 3,
                Name = "Test",
                Description = "Test",
                Age = 10,
                MaxAltitude = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(1, dbContext.Animal.Count(), "Animal added");
        }
        //--------------------------------------------------------------------------------------------------
        //LAND
        [TestMethod]
        public async Task CowCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Cow("Test", "Test", 10, 0)
            {
                Id = 4,
                Name = "Test",
                Description = "Test",
                Age = 10,
                Speed = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(1, dbContext.Animal.Count(), "Animal added");
        }
        [TestMethod]
        public async Task GiganotosaurusCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Giganotosaurus("Test", "Test", 10, 0)
            {
                Id = 5,
                Name = "Test2",
                Description = "Test2",
                Age = 10,
                Speed = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(1, dbContext.Animal.Count(), "Animal added");
        }
        [TestMethod]
        public async Task SantaClausCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new SantaClaus("Test", "Test", 10, 0)
            {
                Id = 6,
                Name = "Test2",
                Description = "Test2",
                Age = 10,
                Speed = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(1, dbContext.Animal.Count(), "Animal added");
        }
        //--------------------------------------------------------------------------------------------------
        //WATER
        [TestMethod]
        public async Task OrcaCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Orca("Test", "Test", 10, 0)
            {
                Id = 7,
                Name = "Test2",
                Description = "Test2",
                Age = 10,
                DivingDepth = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(1, dbContext.Animal.Count(), "Animal added");
        }
        [TestMethod]
        public async Task KrakenCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Kraken("Test", "Test", 10, 0)
            {
                Id = 8,
                Name = "Test2",
                Description = "Test2",
                Age = 10,
                DivingDepth = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(1, dbContext.Animal.Count(), "Animal added");
        }
        [TestMethod]
        public async Task PenguinCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Penguin("Test3", "Test3", 10, 0)
            {
                Id = 9,
                Name = "Test3",
                Description = "Test3",
                Age = 10,
                DivingDepth = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(1, dbContext.Animal.Count(), "Animal added");
        }
        //--------------------------------------------------------------------------------------------------
        //EDIT
        //--------------------------------------------------------------------------------------------------
        //AIR
        [TestMethod]
        public async Task GooseEDITTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Goose("Test3", "Test1", 10, 0)
            {
                Id = 1,
                Name = "Test3",
                Description = "Test1",
                Age = 100,
                MaxAltitude = 0
            };
            var result = adminServices.Edit(newAnimal);
            Assert.IsTrue(await result);
        }
        [TestMethod]
        public async Task DragonEDITTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Dragon("Test3", "Test1", 10, 0)
            {
                Id = 2,
                Name = "Test3",
                Description = "Test1",
                Age = 100,
                MaxAltitude = 0
            };
            var result = adminServices.Edit(newAnimal);
            Assert.IsTrue(await result);
        }
        [TestMethod]
        public async Task GriffinEDITTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Griffin("Test3", "Test1", 10, 0)
            {
                Id = 3,
                Name = "Test3",
                Description = "Test1",
                Age = 100,
                MaxAltitude = 0
            };
            var result = adminServices.Edit(newAnimal);
            Assert.IsTrue(await result);
        }
        //--------------------------------------------------------------------------------------------------
        //LAND
        [TestMethod]
        public async Task CowEDITTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Cow("Test3", "Test1", 10, 0)
            {
                Id = 4,
                Name = "Test3",
                Description = "Test1",
                Age = 100,
                Speed = 0
            };
            var result = adminServices.Edit(newAnimal);
            Assert.IsTrue(await result);
        }
        [TestMethod]
        public async Task GiganotosaurusEDITTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Giganotosaurus("Test3", "Test1", 10, 0)
            {
                Id = 5,
                Name = "Test3",
                Description = "Test1",
                Age = 100,
                Speed = 0
            };
            var result = adminServices.Edit(newAnimal);
            Assert.IsTrue(await result);
        }
        [TestMethod]
        public async Task SantaClausEDITTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new SantaClaus("Test3", "Test1", 10, 0)
            {
                Id = 6,
                Name = "Test3",
                Description = "Test1",
                Age = 100,
                Speed = 0
            };
            var result = adminServices.Edit(newAnimal);
            Assert.IsTrue(await result);
        }
        //--------------------------------------------------------------------------------------------------
        //WATER
        [TestMethod]
        public async Task OrcaEDITTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Orca("Test3", "Test1", 10, 0)
            {
                Id = 7,
                Name = "Test3",
                Description = "Test1",
                Age = 100,
                DivingDepth = 0
            };
            var result = adminServices.Edit(newAnimal);
            Assert.IsTrue(await result);
        }
        [TestMethod]
        public async Task KrakenEDITTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Kraken("Test3", "Test1", 10, 0)
            {
                Id = 8,
                Name = "Test3",
                Description = "Test1",
                Age = 100,
                DivingDepth = 0
            };
            var result = adminServices.Edit(newAnimal);
            Assert.IsTrue(await result);
        }
        [TestMethod]
        public async Task PenguinEDITTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Penguin("Test3", "Test1", 10, 0)
            {
                Id = 9,
                Name = "Test3",
                Description = "Test1",
                Age = 100,
                DivingDepth = 0
            };
            var result = adminServices.Edit(newAnimal);
            Assert.IsTrue(await result);
        }
        //--------------------------------------------------------------------------------------------------
        //REMOVE
        //--------------------------------------------------------------------------------------------------
        //AIR
        [TestMethod]
        public async Task GooseREMOVETest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Goose("Test3", "Test3", 10, 0)
            {
                Id = 1,
                Name = "Test3",
                Description = "Test3",
                Age = 10,
                MaxAltitude = 0
            };
            var result = adminServices.Delete(newAnimal);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public async Task DragonREMOVETest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Dragon("Test3", "Test3", 10, 0)
            {
                Id = 2,
                Name = "Test3",
                Description = "Test3",
                Age = 10,
                MaxAltitude = 0
            };
            var result = adminServices.Delete(newAnimal);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public async Task GriffinREMOVETest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Griffin("Test3", "Test3", 10, 0)
            {
                Id = 3,
                Name = "Test3",
                Description = "Test3",
                Age = 10,
                MaxAltitude = 0
            };
            var result = adminServices.Delete(newAnimal);
            Assert.IsTrue(result);
        }
        //--------------------------------------------------------------------------------------------------
        //LAND
        [TestMethod]
        public async Task CowREMOVETest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Cow("Test3", "Test3", 10, 0)
            {
                Id = 4,
                Name = "Test3",
                Description = "Test3",
                Age = 10,
                Speed = 0
            };
            var result = adminServices.Delete(newAnimal);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public async Task GiganotosaurusREMOVETest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Giganotosaurus("Test3", "Test3", 10, 0)
            {
                Id = 5,
                Name = "Test3",
                Description = "Test3",
                Age = 10,
                Speed = 0
            };
            var result = adminServices.Delete(newAnimal);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public async Task SantaClausREMOVETest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new SantaClaus("Test3", "Test3", 10, 0)
            {
                Id = 6,
                Name = "Test3",
                Description = "Test3",
                Age = 10,
                Speed = 0
            };
            var result = adminServices.Delete(newAnimal);
            Assert.IsTrue(result);
        }
        //--------------------------------------------------------------------------------------------------
        //WATER
        [TestMethod]
        public async Task OrcaREMOVETest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Orca("Test3", "Test3", 10, 0)
            {
                Id = 7,
                Name = "Test3",
                Description = "Test3",
                Age = 10,
                DivingDepth = 0
            };
            var result = adminServices.Delete(newAnimal);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public async Task KrakenREMOVETest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Kraken("Test3", "Test3", 10, 0)
            {
                Id = 8,
                Name = "Test3",
                Description = "Test3",
                Age = 10,
                DivingDepth = 0
            };
            var result = adminServices.Delete(newAnimal);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public async Task PenguinREMOVETest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Penguin("Test3", "Test3", 10, 0)
            {
                Id = 9,
                Name = "Test3",
                Description = "Test3",
                Age = 10,
                DivingDepth = 0
            };
            var result = adminServices.Delete(newAnimal);
            Assert.IsTrue(result);
        }
    }
}