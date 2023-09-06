using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EatEaze.Data.DataContext
{
    public class EatEazeDataContextDesignTimeFactory : IDesignTimeDbContextFactory<EatEazeDataContext>
    {
        #region IDesignTimeDbContextFactory<CapitalizationDataContext> Members

        public EatEazeDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EatEazeDataContext>();
            optionsBuilder.UseNpgsql(
                "host=localhost;port=5800;database=eateazedatabase;username=eateaze-app;password=Ml37RemA7hEGjI");

            return new EatEazeDataContext(optionsBuilder.Options);
        }

        #endregion
    }
}