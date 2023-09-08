using EatEaze.Data.Repositories;

namespace EatEaze.Data.DataContext
{
    public interface IEatEazeDataContext : IDisposable
    {
        public CityRepository CityRepository { get; }
        public OrderRepository OrderRepository { get; }
        public PositionRepository PositionRepository { get; }
        public RestarauntRepository RestarauntRepository { get; }
        public RoleRepository RoleRepository { get; }
        public UserRepository UserRepository { get; }


    }
}