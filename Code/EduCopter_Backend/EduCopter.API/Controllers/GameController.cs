using EduCopter.Domain.Game;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class GameController : AbstractEntityController<Game>
    {
        public GameController(IEntityLogic<Game> logic) : base(logic)
        {
        }
    }
}
