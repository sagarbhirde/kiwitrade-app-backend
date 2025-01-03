using eKiwiTradeApi.Logic.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eKiwiTradeApi.Query.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : Controller
    {
        private readonly ILookupService _lookupService;
        public MessageController(ILookupService lookupService)
        {
            _lookupService = lookupService;
        }


        [HttpGet("GetUserProducts")]
        public async Task<IActionResult> GetUserProducts(int UserId)
        {
            //return Ok(await _lookupService.GetAllLookupAsync().ConfigureAwait(false));
            return Ok();
        }

        [HttpGet("GetUserProductChats")]
        public async Task<IActionResult> GetUserProductChats(int userId, long productId)
        {
            //return Ok(await _lookupService.GetAllLookupAsync().ConfigureAwait(false));
            return Ok();
        }

        [HttpGet("GetUserProductChatMessages")]
        public async Task<IActionResult> GetUserProductChatMessages(int userId, long productId, long chatId)
        {
            //return Ok(await _lookupService.GetAllLookupAsync().ConfigureAwait(false));
            return Ok();
        }


    }
}
