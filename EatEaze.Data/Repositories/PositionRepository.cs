using EatEaze.Data.DataContext;
using EatEaze.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace EatEaze.Data.Repositories
{
    public class PositionRepository : BaseRepository<Position>
    {
        public PositionRepository(EatEazeDataContext dataContext) : base(dataContext)
        {
        }
    }
}