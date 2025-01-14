using eKiwiTradeApi.Logic.Interface;
using eKiwiTradeApi.Logic.Model;
using Microsoft.AspNetCore.Mvc;

namespace eKiwiTradeApi.Query.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            return Ok(await _userService.GetAllUserAsync().ConfigureAwait(false));
        }


        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> GetUser(string id)
        {
            return Ok(await _userService.GetUserByIdAsync(id).ConfigureAwait(false));
           
        }
    }
}
