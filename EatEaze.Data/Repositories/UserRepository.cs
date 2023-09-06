using EatEaze.Data.DataContext;
using EatEaze.Data.Entites;
using Microsoft.EntityFrameworkCore;


namespace EatEaze.Data.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(EatEazeDataContext dataContext) : base(dataContext)
        {
        }
    }
}