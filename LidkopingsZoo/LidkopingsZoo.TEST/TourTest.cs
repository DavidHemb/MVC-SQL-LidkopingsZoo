using LidkopingsZoo.Data;
using LidkopingsZoo.Models.Visitation;
using LidkopingsZoo.Services.Guides;
using LidkopingsZoo.Services.Tours;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LidkopingsZoo.TEST
{
    [TestClass]
    public class TourTest
    {
        private ApplicationDbContext dbContext;
        //Visit newTour = InitializeTour(); // Declare newTour as a class-level variable

        [TestInitialize]
        public void Initialize()
        {
            dbContext = GetInMemoryDbContext();
        }

        // Initializes a mock tour for test purpose.
        public static Visit InitializeTour()
        {
            Guide testGuide = new Guide
            {
                Id = 1,
                Name = "TestGuido",
                Email = "TestGuido@mail.com"
            };

            var newTour = new Visit
            {
                Id = 1,
                Guides = testGuide,
                VisitDay = DateTime.Now,
                VisitTime = "Afternoon",
                Species = "Cow",
                Visitors = 3,
                UserId = "exampleuserid"
            };

            return newTour;
        }

        // Sets up a InMemoryDatabase for testing.
        private ApplicationDbContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
                .Options;
            return new ApplicationDbContext(options);
        }

        [TestMethod]
        public async Task CreateTour_Should_Add_Tour_To_Context()
        {
            // Arrange
            var tourServices = new TourServices(dbContext);
            var newTour = InitializeTour();
            newTour.Id = 1;
            

            // Act
            var result = await tourServices.CreateTour(newTour);

            // Assert
            Assert.IsTrue(result, "CreateTour should return true when successfully adding a tour to the context.");
            Assert.AreEqual(1, dbContext.Visits.Count(), "One tour should be added to the context.");
        }

        [TestMethod]
        public async Task DeleteTour_Should_Remove_Tour_From_Context()
        {
            // Arrange
            var tourServices = new TourServices(dbContext);
            var newTour = InitializeTour();
            newTour.Id = 1;

            // Act
            var result = await tourServices.DeleteTour(newTour);

            // Assert
            Assert.IsTrue(result, "DeleteTour should return true when successfully removing a tour from the context.");
            Assert.AreEqual(0, dbContext.Visits.Count(), "No tours should be left in the context after deletion.");
        }
    }
}
