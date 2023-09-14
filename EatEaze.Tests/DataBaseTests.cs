using EatEaze.Data.DataContext;
using EatEaze.Data.Entites;
using NUnit.Framework;

namespace EatEaze.Tests
{
    public class DataBaseTests
    {

        private EatEazeDataContext _eatEazeDataContext = new EatEazeDataContextDesignTimeFactory().CreateDbContext(null);

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void AddSomethinToDbTest()
        {
            Restaraunt restaraunt = new Restaraunt();
            restaraunt.RestarauntId = 1;
            restaraunt.RestarauntName = "RestarauntTest";
            restaraunt.RestarauntIcon = null;
            Position position = new Position();
            position.PositionId = 1;
            position.PositionName = "PositiontTest";
            position.RestarauntId = restaraunt.RestarauntId;
            position.Restaraunt = restaraunt;

            _eatEazeDataContext.RestarauntRepository.AddItem(restaraunt);
            _eatEazeDataContext.PositionRepository.AddItem(position);

        }

        [Test]
        public void DeleteFromDbTest()
        {
            var position = _eatEazeDataContext.PositionRepository.GetListOfItem().FirstOrDefault(p => p.PositionId == 1);
            var restaraunt = _eatEazeDataContext.RestarauntRepository.GetListOfItem().FirstOrDefault(p => p.RestarauntId == 1);
            _eatEazeDataContext.PositionRepository.DeleteItem(position);
            _eatEazeDataContext.RestarauntRepository.DeleteItem(restaraunt);
        }
    }
}