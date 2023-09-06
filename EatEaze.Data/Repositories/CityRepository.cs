using Microsoft.EntityFrameworkCore;
using EatEaze.Data.Entites;
using EatEaze.Data.DataContext;

namespace EatEaze.Data.Repositories
{
    public class CityRepository : BaseRepository<City>
    {
        public CityRepository(EatEazeDataContext dataContext) : base(dataContext)
        {
        }
    }
}