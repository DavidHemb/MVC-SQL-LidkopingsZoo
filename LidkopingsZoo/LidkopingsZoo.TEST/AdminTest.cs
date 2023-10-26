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
        //AIR
        [TestMethod]
        public async Task GooseCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Goose("Test", "Test", 10, 0)
            {
                Name = "Test",
                Description = "Test",
                Age = 10,
                MaxAltitude = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(4, dbContext.Animal.Count(), "Animal added");
        }
        [TestMethod]
        public async Task DragonCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Dragon("Test", "Test", 10, 0)
            {
                Name = "Test",
                Description = "Test",
                Age = 10,
                MaxAltitude = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(2, dbContext.Animal.Count(), "Animal added");
        }
        //LAND
        [TestMethod]
        public async Task GriffinCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Griffin("Test", "Test", 10, 0)
            {
                Name = "Test",
                Description = "Test",
                Age = 10,
                MaxAltitude = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(5, dbContext.Animal.Count(), "Animal added");
        }
        //LAND
        [TestMethod]
        public async Task CowCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Cow("Test", "Test", 10, 0)
            {
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
                Name = "Test2",
                Description = "Test2",
                Age = 10,
                Speed = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(3, dbContext.Animal.Count(), "Animal added");
        }
        [TestMethod]
        public async Task SantaClausCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new SantaClaus("Test", "Test", 10, 0)
            {
                Name = "Test2",
                Description = "Test2",
                Age = 10,
                Speed = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(9, dbContext.Animal.Count(), "Animal added");
        }
        //WATER
        [TestMethod]
        public async Task OrcaCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Orca("Test", "Test", 10, 0)
            {
                Name = "Test2",
                Description = "Test2",
                Age = 10,
                DivingDepth = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(7, dbContext.Animal.Count(), "Animal added");
        }
        [TestMethod]
        public async Task KrakenCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Kraken("Test", "Test", 10, 0)
            {
                Name = "Test2",
                Description = "Test2",
                Age = 10,
                DivingDepth = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(6, dbContext.Animal.Count(), "Animal added");
        }
        [TestMethod]
        public async Task PenguinCreationTest()
        {
            var adminServices = new AdminServices(dbContext);
            newAnimal = new Penguin("Test", "Test", 10, 0)
            {
                Name = "Test2",
                Description = "Test2",
                Age = 10,
                DivingDepth = 0
            };
            var result = adminServices.AddAnimal(newAnimal);
            Assert.IsTrue(result, "AddAnimal should return true when successfull");
            Assert.AreEqual(8, dbContext.Animal.Count(), "Animal added");
        }
        //----------------------------------------------------------------------------------------------
        //EDIT
        //----------------------------------------------------------------------------------------------
        //[TestMethod]
        //public async Task GooseEditTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Goose("Test", "Test", 10, 0)
        //    {
        //        Name = "Test",
        //        Description = "Test",
        //        Age = 10,
        //        MaxAltitude = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(1, dbContext.Animal.Count(), "Animal added");
        //}
        //[TestMethod]
        //public async Task DragonEditTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Dragon("Test", "Test", 10, 0)
        //    {
        //        Name = "Test",
        //        Description = "Test",
        //        Age = 10,
        //        MaxAltitude = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(2, dbContext.Animal.Count(), "Animal added");
        //}
        ////LAND
        //[TestMethod]
        //public async Task GriffinEditTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Griffin("Test", "Test", 10, 0)
        //    {
        //        Name = "Test",
        //        Description = "Test",
        //        Age = 10,
        //        MaxAltitude = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(3, dbContext.Animal.Count(), "Animal added");
        //}
        ////LAND
        //[TestMethod]
        //public async Task CowEditTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Cow("Test", "Test", 10, 0)
        //    {
        //        Name = "Test",
        //        Description = "Test",
        //        Age = 10,
        //        Speed = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(4, dbContext.Animal.Count(), "Animal added");
        //}
        //[TestMethod]
        //public async Task GiganotosaurusEditTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Giganotosaurus("Test", "Test", 10, 0)
        //    {
        //        Name = "Test2",
        //        Description = "Test2",
        //        Age = 10,
        //        Speed = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(5, dbContext.Animal.Count(), "Animal added");
        //}
        //[TestMethod]
        //public async Task SantaClausEditTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new SantaClaus("Test", "Test", 10, 0)
        //    {
        //        Name = "Test2",
        //        Description = "Test2",
        //        Age = 10,
        //        Speed = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(6, dbContext.Animal.Count(), "Animal added");
        //}
        ////WATER
        //[TestMethod]
        //public async Task OrcaEditTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Orca("Test", "Test", 10, 0)
        //    {
        //        Name = "Test2",
        //        Description = "Test2",
        //        Age = 10,
        //        DivingDepth = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(7, dbContext.Animal.Count(), "Animal added");
        //}
        //[TestMethod]
        //public async Task KrakenEditTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Kraken("Test", "Test", 10, 0)
        //    {
        //        Name = "Test2",
        //        Description = "Test2",
        //        Age = 10,
        //        DivingDepth = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(8, dbContext.Animal.Count(), "Animal added");
        //}
        //[TestMethod]
        //public async Task PenguinEditTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Penguin("Test", "Test", 10, 0)
        //    {
        //        Name = "Test2",
        //        Description = "Test2",
        //        Age = 10,
        //        DivingDepth = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(9, dbContext.Animal.Count(), "Animal added");
        //}
        ////----------------------------------------------------------------------------------------------
        ////REMOVE
        ////----------------------------------------------------------------------------------------------
        //[TestMethod]
        //public async Task GooseRemoveTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Goose("Test", "Test", 10, 0)
        //    {
        //        Name = "Test",
        //        Description = "Test",
        //        Age = 10,
        //        MaxAltitude = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(1, dbContext.Animal.Count(), "Animal added");
        //}
        //[TestMethod]
        //public async Task DragonRemoveCreationTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Dragon("Test", "Test", 10, 0)
        //    {
        //        Name = "Test",
        //        Description = "Test",
        //        Age = 10,
        //        MaxAltitude = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(2, dbContext.Animal.Count(), "Animal added");
        //}
        ////LAND
        //[TestMethod]
        //public async Task GriffinRemoveTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Griffin("Test", "Test", 10, 0)
        //    {
        //        Name = "Test",
        //        Description = "Test",
        //        Age = 10,
        //        MaxAltitude = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(3, dbContext.Animal.Count(), "Animal added");
        //}
        ////LAND
        //[TestMethod]
        //public async Task CowRemoveTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Cow("Test", "Test", 10, 0)
        //    {
        //        Name = "Test",
        //        Description = "Test",
        //        Age = 10,
        //        Speed = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(4, dbContext.Animal.Count(), "Animal added");
        //}
        //[TestMethod]
        //public async Task GiganotosaurusRemoveTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Giganotosaurus("Test", "Test", 10, 0)
        //    {
        //        Name = "Test2",
        //        Description = "Test2",
        //        Age = 10,
        //        Speed = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(5, dbContext.Animal.Count(), "Animal added");
        //}
        //[TestMethod]
        //public async Task SantaClausRemoveTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new SantaClaus("Test", "Test", 10, 0)
        //    {
        //        Name = "Test2",
        //        Description = "Test2",
        //        Age = 10,
        //        Speed = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(6, dbContext.Animal.Count(), "Animal added");
        //}
        ////WATER
        //[TestMethod]
        //public async Task OrcaRemoveTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Orca("Test", "Test", 10, 0)
        //    {
        //        Name = "Test2",
        //        Description = "Test2",
        //        Age = 10,
        //        DivingDepth = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(7, dbContext.Animal.Count(), "Animal added");
        //}
        //[TestMethod]
        //public async Task KrakenRemoveTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Kraken("Test", "Test", 10, 0)
        //    {
        //        Name = "Test2",
        //        Description = "Test2",
        //        Age = 10,
        //        DivingDepth = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(8, dbContext.Animal.Count(), "Animal added");
        //}
        //[TestMethod]
        //public async Task PenguinRemoveTest()
        //{
        //    var adminServices = new AdminServices(dbContext);
        //    newAnimal = new Penguin("Test", "Test", 10, 0)
        //    {
        //        Name = "Test2",
        //        Description = "Test2",
        //        Age = 10,
        //        DivingDepth = 0
        //    };
        //    var result = adminServices.AddAnimal(newAnimal);
        //    Assert.IsTrue(result, "AddAnimal should return true when successfull");
        //    Assert.AreEqual(9, dbContext.Animal.Count(), "Animal added");
        //}
    }
}