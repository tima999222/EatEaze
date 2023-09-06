using EatEaze.Data.DataContext;
using EatEaze.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace EatEaze.Data.Repositories
{
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(EatEazeDataContext dataContext) : base(dataContext)
        {
        }
    }
}