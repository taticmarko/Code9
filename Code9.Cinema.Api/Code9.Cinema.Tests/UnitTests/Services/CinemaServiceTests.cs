using Code9.Cinema.Domain.Models;
using Code9.Cinema.Domain.Services;
using Code9.Cinema.Infrastructure.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Code9.Cinema.Tests.UnitTests.Services
{
    public class CinemaServiceTests
    {
        private Mock<ICinemaRepository> _mockCinemaRepository;

        public CinemaServiceTests()
        {
            _mockCinemaRepository = new Mock<ICinemaRepository>();
        }

        [Fact]
        public void GetAllAsync_Returns_CinemaCollection()
        {
            // Arrange
            var cinemasCollection = new List<Infrastructure.Models.Cinema>()
            {
                new Infrastructure.Models.Cinema()
                {
                    City = "Novi Sad",
                    Id = Guid.Parse("a23422f3-27bc-4513-a14a-cba87aefcb31"),
                    Name = "Arena Star",
                    NumberOfAuditoriums = 22,
                    Street = "Bulevar Oslobodjenja 25"
                },
                new Infrastructure.Models.Cinema()
                {
                    City = "Beograd",
                    Id = Guid.Parse("a23422f3-2222-1111-a14a-cba87aefcb31"),
                    Name = "Cinemania",
                    NumberOfAuditoriums = 315,
                    Street = "Kralja Petra II"
                }
            };

            var expectedCinemasCollection = new List<CinemaDomainModel>()
            {
                new CinemaDomainModel()
                {
                    City = "Novi Sad",
                    Id = Guid.Parse("a23422f3-27bc-4513-a14a-cba87aefcb31"),
                    Name = "Arena Star",
                    NumberOfAuditoriums = 22,
                    Street = "Bulevar Oslobodjenja 25"
                },
                new CinemaDomainModel()
                {
                    City = "Beograd",
                    Id = Guid.Parse("a23422f3-2222-1111-a14a-cba87aefcb31"),
                    Name = "Cinemania",
                    NumberOfAuditoriums = 315,
                    Street = "Kralja Petra II"
                }
            };

            _mockCinemaRepository
                .Setup(x => x.GetAll())
                .Returns(cinemasCollection);

            // Act
            var cinemaService = new CinemaService(_mockCinemaRepository.Object);
            var getCinemas = cinemaService.GetAllAsync().ToList();

            // Assert
            Assert.NotNull(getCinemas);
            Assert.Equal(expectedCinemasCollection.Count, getCinemas.Count);
            Assert.Equal(expectedCinemasCollection.FirstOrDefault(x => x.City.Equals("Novi Sad")).Id, getCinemas.FirstOrDefault(x => x.City.Equals("Novi Sad")).Id);
            Assert.IsType<List<CinemaDomainModel>>(getCinemas);
        }
    }
}