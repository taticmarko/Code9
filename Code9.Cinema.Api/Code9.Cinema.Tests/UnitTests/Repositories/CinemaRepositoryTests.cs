using Code9.Cinema.Infrastructure;
using Code9.Cinema.Infrastructure.Repositories;
using System.Linq;
using Xunit;

namespace Code9.Cinema.Tests.UnitTests.Repositories
{
    public class CinemaRepositoryTests
    {
        public CinemaRepositoryTests()
        {

        }

        [Fact]
        public void GetAll_Returns_CinemaCollection()
        {
            // Act
            var cinemaRepo = new CinemaRepository();
            var getAllCinemas = cinemaRepo.GetAll();

            // Assert
            Assert.NotNull(getAllCinemas);
            Assert.Equal(DataBase.GetCinemasTable().Count, getAllCinemas.ToList().Count);
        }
    }
}