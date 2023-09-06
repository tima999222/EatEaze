using Microsoft.EntityFrameworkCore;
using EatEaze.Data.Entites;
using EatEaze.Data.Repositories;
using System.Collections.Generic;
using System.Data;

namespace EatEaze.Data.DataContext
{
    public class EatEazeDataContext : DbContext, IEatEazeDataContext
    {
        public EatEazeDataContext(DbContextOptions<EatEazeDataContext> options) : base(options)
        {
            CityRepository = new CityRepository(this);
            OrderRepository = new OrderRepository(this);
            PositionRepository = new PositionRepository(this);
            RestarauntRepository = new RestarauntRepository(this);
            RoleRepository = new RoleRepository(this);
            UserRepository = new UserRepository(this);
        }

        #region DbSets

        public DbSet<City> Cities { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Restaraunt> Restaraunts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion

        #region Repositories

        public CityRepository CityRepository { get; }
        public OrderRepository OrderRepository { get; }
        public PositionRepository PositionRepository { get; }
        public RestarauntRepository RestarauntRepository { get; }
        public RoleRepository RoleRepository { get; }
        public UserRepository UserRepository { get; }


        #endregion

    }
}