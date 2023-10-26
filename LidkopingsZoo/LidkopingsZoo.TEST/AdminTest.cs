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
        //private ApplicationDbContext GetInMemoryDbContext()
        //{
        //    var options = new DbContextOptionsBuilder<ApplicationDbContext>()
        //        .UseInMemoryDatabase(databaseName: "LidkopingsZoo")
        //        .Options;
        //    return new ApplicationDbContext(options);
        //}
        //Animals
        //AIR
        [TestMethod]
        public void GooseCreationTest()
        {
            Animal Goose = new Goose("TestName", "TestDesciption", 10, 0);
        }
        [TestMethod]
        public void GriffinCreationTest()
        {
            Animal Griffin = new Griffin("TestName", "TestDesciption", 10, 0);
        }
        [TestMethod]
        public void DragonCreationTest()
        {
            Animal Dragon = new Dragon("TestName", "TestDesciption", 10, 0);
        }
        //LAND
        [TestMethod]
        public void SantaClausCreationTest()
        {
            Animal SantaClaus = new SantaClaus("TestName", "TestDesciption", 10, 0);
        }
        [TestMethod]
        public void CowCreationTest()
        {
            Animal Cow = new Cow("TestName", "TestDesciption", 10, 0);
        }
        [TestMethod]
        public void GiganotosaurusCreationTest()
        {
            Animal Giganotosaurus = new Giganotosaurus("TestName", "TestDesciption", 10, 0);
        }
        //WATER
        [TestMethod]
        public void OrcaCreationTest()
        {
            Animal Orca = new Orca("TestName", "TestDesciption", 10, 0);
        }
        [TestMethod]
        public void KrakenCreationTest()
        {
            Animal Kraken = new Kraken("TestName", "TestDesciption", 10, 0);
        }
        [TestMethod]
        public void PenguinCreationTest()
        {
            Animal Penguin = new Penguin("TestName", "TestDesciption", 10, 0);
        }
        //[TestMethod]
        //public void AddAnimalTest()
        //{
        //    var dbContext = GetInMemoryDbContext();
        //    var adminServices = new AdminServices(dbContext);

        //    Animal Penguin = new Penguin("TestName", "TestDesciption", 10, 0);
        //    adminServices.AddAnimal(Penguin);
        //}

        // Hjälpmetod för att skapa en in-memory DbContext
        private ApplicationDbContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
                .Options;
            return new ApplicationDbContext(options);
        }
    }
}