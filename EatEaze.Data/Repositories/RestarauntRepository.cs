using EatEaze.Data.DataContext;
using EatEaze.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace EatEaze.Data.Repositories
{
    public class RestarauntRepository : BaseRepository<Restaraunt>
    {
        public RestarauntRepository(EatEazeDataContext dataContext) : base(dataContext)
        {
        }
    }
}