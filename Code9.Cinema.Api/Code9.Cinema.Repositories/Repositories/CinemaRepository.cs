using Code9.Cinema.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace Code9.Cinema.Infrastructure.Repositories
{
    public class CinemaRepository : ICinemaRepository
    {
        public IEnumerable<Models.Cinema> GetAll()
        {
            return DataBase.GetCinemas();
        }
    }
}