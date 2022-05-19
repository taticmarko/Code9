using System.Collections.Generic;
using System.Threading.Tasks;

namespace Code9.Cinema.Infrastructure.Interfaces
{
    public interface ICinemaRepository
    {
        IEnumerable<Models.Cinema> GetAll();
    }
}