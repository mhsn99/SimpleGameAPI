using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gaming.Business;
using Gaming.TransferObjects.Responses;

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService service;
        public GameController(IGameService gameService)
        {
            service = gameService;
        }


        [HttpGet]
        public async Task<IActionResult> GetGames()
        {
            
            var game = await service.GetGamesAsync();
            return Ok(game);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGameById(int id)
        {
            GameDisplayResponse game = await service.GetGame(id);
            return Ok(game);
        }

        [HttpGet("Search Game/{name}")]
        public async Task<IActionResult> SearchGame(string name)
        {
            var response = await service.GetGameByName(name);
            return Ok(response);
        }
    }
}
