using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EatEaze.Data.DataContext
{
    public class EatEazeDataContextDesignTimeFactory : IDesignTimeDbContextFactory<EatEazeDataContext>
    {
        #region IDesignTimeDbContextFactory<EatEazeDataContext> Members

        public EatEazeDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EatEazeDataContext>();
            optionsBuilder.UseNpgsql(
                "host=postgres;port=5432;database=eateazedatabase;username=eateaze-app;password=Ml37RemA7hEGjI");

            var context = new EatEazeDataContext(optionsBuilder.Options);
            context.Database.Migrate();

            return context;
        }

        #endregion
    }
}