using EatEaze.Data.DataContext;
using EatEaze.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace EatEaze.Data.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(EatEazeDataContext dataContext) : base(dataContext)
        {
        }
    }
}