using Code9.Cinema.Api.Controllers;
using Code9.Cinema.Domain.Interfaces;
using Code9.Cinema.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Code9.Cinema.Tests.UnitTests.Controllers
{
    public class CinemaControllerTests
    {
        private readonly Mock<ICinemaService> _mockCinemaService;

        public CinemaControllerTests()
        {
            _mockCinemaService = new Mock<ICinemaService>();
        }

        [Fact]
        public void GetCinemas_Returns_CinemaCollection()
        {
            // Arrange
            var expectedResoultCount = 2;
            var expectedStatusCode = 200;
            var cinemasCollection = new List<CinemaDomainModel>()
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

            _mockCinemaService
                .Setup(x => x.GetAll())
                .Returns(cinemasCollection);

            // Act
            var cinemaController = new CinemaController(_mockCinemaService.Object);
            var response = cinemaController.GetCinemas().Result;

            var resultList = ((OkObjectResult)response).Value;
            var cinemasDomainModelsResult = (List<CinemaDomainModel>)resultList;

            // Assert
            Assert.NotNull(cinemasDomainModelsResult);
            Assert.Equal(expectedResoultCount, cinemasDomainModelsResult.Count);
            Assert.Equal(cinemasCollection, cinemasDomainModelsResult);
            Assert.IsType<List<CinemaDomainModel>>(cinemasDomainModelsResult);
            Assert.IsType<OkObjectResult>(response);
            Assert.Equal(expectedStatusCode, ((OkObjectResult)response).StatusCode);
        }
    }
}