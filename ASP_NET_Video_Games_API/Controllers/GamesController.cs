using ASP_NET_Video_Games_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Video_Games_API.Controllers
{
    // api/Games
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetPublishers()
        {
            var videoGamePublishers = _context.VideoGames;

            return Ok(videoGamePublishers);
        }
        //[HttpGet("{id}")]
        //public IActionResult GetGamesByPublisher(int id)
        //{
        //    //int? maxYear = _context.VideoGames.Select(vg => vg.Year).Max();
        //    //int? minYear = _context.VideoGames.Select(vg => vg.Year).Min();

        //    var videoGames = _context.VideoGames.Where(vg => vg.Id == id);
        //    return Ok(videoGames);
        //}
        [HttpGet("{name}")]
        public IActionResult GetGamesByName(string name)
        {
            var videoGameNames = _context.VideoGames.Where(vgn => vgn.Name.Contains(name));
            return Ok(videoGameNames);
        }
            
    }
}
