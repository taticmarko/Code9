using Code9.Cinema.Domain.Interfaces;
using Code9.Cinema.Domain.Models;
using Code9.Cinema.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Code9.Cinema.Domain.Services
{
    public class CinemaService : ICinemaService
    {
        private readonly ICinemaRepository _cinemaRepository;
        public CinemaService(ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }

        public IEnumerable<CinemaDomainModel> GetAll()
        {
            var cinemas = _cinemaRepository.GetAll();

            if (cinemas == null)
                return null;

            return cinemas.Select(cinema => new CinemaDomainModel()
            {
                Id = cinema.Id,
                City = cinema.City,
                Name = cinema.Name,
                NumberOfAuditoriums = cinema.NumberOfAuditoriums,
                Street = cinema.Street
            }).ToList();
        }
    }
}
