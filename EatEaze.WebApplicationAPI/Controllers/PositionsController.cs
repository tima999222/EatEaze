using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EatEaze.Data.DataContext;
using EatEaze.Data.Entites;

namespace EatEaze.WebApplicationAPI.Controllers
{
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private IEatEazeDataContext _eatEazeDataContext;

        public PositionsController(IEatEazeDataContext eatEazeDataContext)
        {
            if (eatEazeDataContext == null) throw new ArgumentNullException(nameof(eatEazeDataContext));
            _eatEazeDataContext = eatEazeDataContext;
        }

        /// <summary>
        /// Get list of positions
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("positions")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPositions()
        {
            var positions = _eatEazeDataContext.PositionRepository.GetListOfItem();
            if (positions == null) return NotFound();
            return Ok(positions);
        }
    }
}
