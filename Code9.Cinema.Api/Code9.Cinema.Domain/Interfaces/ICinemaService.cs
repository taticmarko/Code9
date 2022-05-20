using Code9.Cinema.Domain.Models;
using System.Collections.Generic;

namespace Code9.Cinema.Domain.Interfaces
{
    public interface ICinemaService
    {
        IEnumerable<CinemaDomainModel> GetAll();
    }
}