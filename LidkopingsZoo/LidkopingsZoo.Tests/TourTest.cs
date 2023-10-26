using Microsoft.VisualStudio.TestTools.UnitTesting;
using LidkopingsZoo;

namespace LidkopingsZoo.Tests
{
    [TestClass]
    public class TourTest
    {
        //[TestMethod]
        //public async Task CreateTour_Should_Add_Tour_To_Context()
        //{
        //    // Arrange
        //    var dbContext = GetInMemoryDbContext();
        //    var tourServices = new TourServices(dbContext);

        //    var newTour = new Visit
        //    {
        //        // Fyll i egenskaper för det nya besöket
        //    };

        //    // Act
        //    var result = await tourServices.CreateTour(newTour);

        //    // Assert
        //    Assert.IsTrue(result, "CreateTour should return true when successfully adding a tour to the context.");
        //    Assert.AreEqual(1, dbContext.Visits.Count(), "One tour should be added to the context.");
        //}

        //[TestMethod]
        //public async Task DeleteTour_Should_Remove_Tour_From_Context()
        //{
        //    // Arrange
        //    var dbContext = GetInMemoryDbContext();
        //    var tourServices = new TourServices(dbContext);

        //    var tourToDelete = new Visit
        //    {
        //        // Fyll i egenskaper för besöket som ska tas bort
        //    };

        //    // Lägg till tourToDelete i contexten innan borttagning
        //    dbContext.Visits.Add(tourToDelete);

        //    // Act
        //    var result = await tourServices.DeleteTour(tourToDelete);

        //    // Assert
        //    Assert.IsTrue(result, "DeleteTour should return true when successfully removing a tour from the context.");
        //    Assert.AreEqual(0, dbContext.Visits.Count(), "No tours should be left in the context after deletion.");
        //}

        //// Hjälpmetod för att skapa en in-memory DbContext
        //private ApplicationDbContext GetInMemoryDbContext()
        //{
        //    var options = new DbContextOptionsBuilder<ApplicationDbContext>()
        //        .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
        //        .Options;
        //    return new ApplicationDbContext(options);
        //}
    }
}